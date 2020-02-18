using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection;
using Client.Extensions;
using Client.Migrators;
using Client.Providers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SaaSDatabase.Models;
using StandaloneDatabase.Models;
using AggregatedCounter = SaaSDatabase.Models.AggregatedCounter;
using AspNetUserClaims = StandaloneDatabase.Models.AspNetUserClaims;
using AspNetUserLogins = StandaloneDatabase.Models.AspNetUserLogins;
using AspNetUserRoles = StandaloneDatabase.Models.AspNetUserRoles;
using AspNetUsers = SaaSDatabase.Models.AspNetUsers;
using Bank = SaaSDatabase.Models.Bank;
using Branch = SaaSDatabase.Models.Branch;
using Category = SaaSDatabase.Models.Category;
using Company = SaaSDatabase.Models.Company;
using Counter = SaaSDatabase.Models.Counter;
using Customer = SaaSDatabase.Models.Customer;
using Delivery = SaaSDatabase.Models.Delivery;
using Deposit = SaaSDatabase.Models.Deposit;
using DepositHead = SaaSDatabase.Models.DepositHead;
using Employee = SaaSDatabase.Models.Employee;
using Expense = SaaSDatabase.Models.Expense;
using ExpenseHead = SaaSDatabase.Models.ExpenseHead;
using Hash = SaaSDatabase.Models.Hash;
using Job = SaaSDatabase.Models.Job;
using JobParameter = SaaSDatabase.Models.JobParameter;
using JobQueue = SaaSDatabase.Models.JobQueue;
using List = SaaSDatabase.Models.List;
using MigrationHistory = SaaSDatabase.Models.MigrationHistory;
using Partner = SaaSDatabase.Models.Partner;
using Product = SaaSDatabase.Models.Product;
using PurchaseOrder = SaaSDatabase.Models.PurchaseOrder;
using PurchaseReceive = SaaSDatabase.Models.PurchaseReceive;
using PurchaseReturn = SaaSDatabase.Models.PurchaseReturn;
using Sale = SaaSDatabase.Models.Sale;
using SaleReturn = SaaSDatabase.Models.SaleReturn;
using Schema = SaaSDatabase.Models.Schema;
using Server = SaaSDatabase.Models.Server;
using Set = SaaSDatabase.Models.Set;
using State = SaaSDatabase.Models.State;
using Subcategory = SaaSDatabase.Models.Subcategory;
using Supplier = SaaSDatabase.Models.Supplier;
using SupplierCategory = SaaSDatabase.Models.SupplierCategory;
using Warehouse = SaaSDatabase.Models.Warehouse;

namespace Client
{
    internal class Program
    {
        private static DbContextOptionsBuilder<TilesCornerDbContext> _sourceOptionsBuilder;
        private static DbContextOptionsBuilder<TilesPadDbContext> _destinationOptionsBuilder;
        private static IConfigurationRoot _configureServices;

        private static void Main(string[] args)
        {
            Console.WriteLine("Initializing...");

            #region Startup

            // Create service collection
            var serviceCollection = new ServiceCollection();
            _configureServices = Startup.ConfigureServices(serviceCollection);

            // Create service provider
            IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();

            #endregion


            #region initiatlize

            _sourceOptionsBuilder = new DbContextOptionsBuilder<TilesCornerDbContext>();
            _sourceOptionsBuilder.UseSqlServer(_configureServices.GetConnectionString("SourceConnection"));
            Console.WriteLine(
                $"Connected source database....{_configureServices.GetConnectionString("SourceConnection")}");

            _destinationOptionsBuilder = new DbContextOptionsBuilder<TilesPadDbContext>();
            _destinationOptionsBuilder.UseSqlServer(_configureServices.GetConnectionString("DestinationConnection"));
            Console.WriteLine(
                $"Connected target database....{_configureServices.GetConnectionString("DestinationConnection")}");

            Migrator.Initialize(new TilesCornerDbContext(_sourceOptionsBuilder.Options),
                new TilesPadDbContext(_destinationOptionsBuilder.Options));

            StartInit:
            Console.WriteLine("Enter you tenancy name to start the operation");
            var tenancyName = Console.ReadLine();
            var tenantId = MigrationProvider.GetTenantId(tenancyName, _destinationOptionsBuilder);
            if (string.IsNullOrWhiteSpace(tenantId)) goto StartInit;
            var companyId = MigrationProvider.GetCompanyId(tenantId, _destinationOptionsBuilder);

            Migrator.Setup(tenantId, companyId);

            Console.WriteLine($"{tenancyName} is found on SaaS database. What do you want to do now?");
            Console.WriteLine("1. Migrate \n2. Clean\n3. Exit");

            var action = Console.ReadLine();

            #endregion

            if (action == "1" || action?.ToLower() == "migrate")
            {
                Console.WriteLine("Please enter the source database name...");
                while (true)
                {
                    var sourceDatabaseName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(sourceDatabaseName))
                    {
                        var connectionString = _configureServices.GetConnectionString("SourceConnection");
                        var strings = connectionString.Split(";");

                        var database = strings.FirstOrDefault(x => x.StartsWith("Database"));
                        var databaseIndex = strings.IndexOf(database);

                        var split = database.Split("=");
                        split[1] = sourceDatabaseName;
                        strings[databaseIndex] = $"{split[0]}={split[1]}";

                        connectionString = string.Join(";", strings);

                        _sourceOptionsBuilder.UseSqlServer(connectionString);
                        Console.WriteLine($"Connecting to source database....{connectionString}");

                        Migrator.Initialize(new TilesCornerDbContext(_sourceOptionsBuilder.Options),
                            new TilesPadDbContext(_destinationOptionsBuilder.Options));

                        if (Migrator.IsDatabaseExist(Migrator.SourceContext))
                        {
                            Console.WriteLine("Database found....connection success....");
                            break;
                        }
                    }

                    Console.WriteLine(
                        "Could not find the database with given key, please enter another name to continue.....");
                }

                StartMigration:
                Console.WriteLine(
                    $"All are set now, are you sure you want to start migration of {tenancyName} now???.....");
                Console.WriteLine("\n1. Yes \t2. No \t0. Exit");

                var confirm = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(confirm))
                {
                    if (confirm.ToLower() == "yes" || confirm == "1")
                    {
                        DoMigration(tenantId, companyId);
                    }
                    else if (confirm.ToLower() == "no" || confirm == "2")
                    {
                    }
                    else if (confirm.ToLower() == "exit" || confirm == "0")
                    {
                        action = "3";
                    }
                    else
                    {
                        Console.WriteLine("Wrong input....");
                        goto StartMigration;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input....");
                    goto StartMigration;
                }
            }

            if (action == "2" || action?.ToLower() == "clean")
            {
                StartDeletion:
                Console.WriteLine($"Are you sure you want to delete all data from {tenancyName}???.....");
                Console.WriteLine("\n1. Yes \t2. No \t0. Exit");

                var confirm = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(confirm))
                {
                    if (confirm.ToLower() == "yes" || confirm == "1")
                    {
                        DoClean(tenantId, companyId);
                    }
                    else if (confirm.ToLower() == "no" || confirm == "2")
                    {
                        action = "3";
                    }
                    else if (confirm.ToLower() == "exit" || confirm == "0")
                    {
                        action = "3";
                    }
                    else
                    {
                        Console.WriteLine("Wrong input....");
                        goto StartDeletion;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input....");
                    goto StartDeletion;
                }
            }

            if (action == "3" || action?.ToLower() == "exit") Console.WriteLine($"Operation exit for {tenancyName}");

            Console.WriteLine($"Operation finished for {tenancyName}");
            OperationReInit:
            Console.WriteLine($"\nDo you wish to continue with another tenant?\n\n1. Yes \t0. Exit");
            action = Console.ReadLine();
            if (action == "1" || action?.ToLower() == "yes") goto StartInit;
            if (action == "0" || action?.ToLower() == "exit")
            {
                Console.WriteLine("Operation exit....");
            }
            else
            {
                Console.WriteLine("Wrong input....");
                goto OperationReInit;
            }
        }

        //Delete tenant and all related data from SaaS Database
        private static void DoClean(string tenantId, string companyId)
        {
            var entityTypes = Migrator.DestinationContext.Model.GetEntityTypes().OrderBy(x => x.Name).ToList();

            var saaSDatabaseAssembly = Assembly.Load($"{nameof(SaaSDatabase)}");
            var saaSDatabaseAssemblyTypes = saaSDatabaseAssembly.GetTypes();

            var stack = new Stack<IEntityType>();

            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(Tenant).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(AspNetUsers).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(Company).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(Warehouse).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(Branch).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(AppRoles).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(Bank).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(Customer).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(Supplier).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(Category).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(Subcategory).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(Product).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SupplierCategory).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(Partner).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(Employee).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(DepositHead).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(Deposit).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(ExpenseHead).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(Expense).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(PurchaseOrder).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(PurchaseReceive).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(PurchaseReturn).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(Sale).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(Delivery).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SaleReturn).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(TimeSheet).FullName));

            var enumerable = entityTypes.Except(stack.ToList()).ToList();

            foreach (var entityType in enumerable) stack.Push(entityType);

            //_destinationOptionsBuilder.UseSqlServer(_configureServices.GetConnectionString("DestinationConnection") + "Foreign Keys=false;");
            Migrator.Initialize(new TilesCornerDbContext(_sourceOptionsBuilder.Options),
                new TilesPadDbContext(_destinationOptionsBuilder.Options));

            foreach (var item in stack)
            {
                Console.WriteLine($"Traversing  {item.Name}.....");

                if (item.Name == $"{typeof(AggregatedCounter).FullName}") continue;
                if (item.Name == $"{typeof(Hash).FullName}") continue;
                if (item.Name == $"{typeof(Counter).FullName}") continue;
                if (item.Name == $"{typeof(Job).FullName}") continue;
                if (item.Name == $"{typeof(JobParameter).FullName}") continue;
                if (item.Name == $"{typeof(JobQueue).FullName}") continue;
                if (item.Name == $"{typeof(List).FullName}") continue;
                if (item.Name == $"{typeof(MigrationHistory).FullName}") continue;
                if (item.Name == $"{typeof(Schema).FullName}") continue;
                if (item.Name == $"{typeof(Server).FullName}") continue;
                if (item.Name == $"{typeof(Set).FullName}") continue;
                if (item.Name == $"{typeof(State).FullName}") continue;

                if (item.Name == $"{typeof(Edition).FullName}") continue;
                if (item.Name == $"{typeof(Feature).FullName}") continue;
                if (item.Name == $"{typeof(Rfq).FullName}") continue;
                if (item.Name == $"{typeof(HostSetting).FullName}") continue;

                var entityType = saaSDatabaseAssemblyTypes.FirstOrDefault(t => t.FullName == item.Name);
                if (entityType != null)
                {
                    var queryable = Migrator.DestinationContext.Set(entityType);

                    var objects = item.Name == $"{typeof(Tenant).FullName}"
                        ? queryable.Where("Id==@0", tenantId).ToList()
                        : queryable.Where("TenantId==@0", tenantId).ToList();

                    if (objects.Any())
                    {
                        if (item.Name == $"{typeof(AspNetUsers).FullName}")
                        {
                            var aspNetUserses = Migrator.Mapper.Map<List<AspNetUsers>>(objects);
                            aspNetUserses.ForEach(x => x.BranchId = null);
                            Migrator.DestinationContext.BulkUpdate(aspNetUserses);
                            Migrator.DestinationContext.BulkSaveChanges();
                        }
                        if (item.Name == $"{typeof(Employee).FullName}")
                        {
                            var employees = Migrator.Mapper.Map<List<SaaSDatabase.Models.Employee>>(objects);
                            employees.ForEach(x => x.BranchId = null);
                            Migrator.DestinationContext.BulkUpdate(employees);
                            Migrator.DestinationContext.BulkSaveChanges();
                        }

                        Console.WriteLine($"Deleting {objects.Count} items from {entityType}.....");
                        Migrator.DestinationContext.BulkDelete(objects);
                        Migrator.DestinationContext.BulkSaveChanges();
                    }
                }
            }

            Migrator.DestinationContext.BulkSaveChanges();
        }


        private static void DoMigration(string tenantId, string companyId)
        {
            #region Read source database entities

            Console.WriteLine($"Migration Started at {DateTime.Now}");

            var standaloneDatabaseAssembly = Assembly.Load($"{nameof(StandaloneDatabase)}");
            var standaloneDatabaseAssemblyTypes = standaloneDatabaseAssembly.GetTypes();

            var entityTypes = Migrator.SourceContext.Model.GetEntityTypes().OrderBy(x => x.Name).ToList();
            var queue = new Queue<IEntityType>();

            queue.Enqueue(
                entityTypes.FirstOrDefault(x => x.Name == typeof(StandaloneDatabase.Models.Warehouse).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(StandaloneDatabase.Models.Branch).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x =>
                x.Name == typeof(StandaloneDatabase.Models.AspNetUsers).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(StandaloneDatabase.Models.Bank).FullName));
            queue.Enqueue(
                entityTypes.FirstOrDefault(x => x.Name == typeof(StandaloneDatabase.Models.Customer).FullName));
            queue.Enqueue(
                entityTypes.FirstOrDefault(x => x.Name == typeof(StandaloneDatabase.Models.Supplier).FullName));
            queue.Enqueue(
                entityTypes.FirstOrDefault(x => x.Name == typeof(StandaloneDatabase.Models.Category).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x =>
                x.Name == typeof(StandaloneDatabase.Models.Subcategory).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x =>
                x.Name == typeof(StandaloneDatabase.Models.Product).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x =>
                x.Name == typeof(StandaloneDatabase.Models.SupplierCategory).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x =>
                x.Name == typeof(StandaloneDatabase.Models.Partner).FullName));
            queue.Enqueue(
                entityTypes.FirstOrDefault(x => x.Name == typeof(StandaloneDatabase.Models.Employee).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x =>
                x.Name == typeof(StandaloneDatabase.Models.DepositHead).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x =>
                x.Name == typeof(StandaloneDatabase.Models.Deposit).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x =>
                x.Name == typeof(StandaloneDatabase.Models.ExpenseHead).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x =>
                x.Name == typeof(StandaloneDatabase.Models.Expense).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x =>
                x.Name == typeof(StandaloneDatabase.Models.PurchaseOrder).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x =>
                x.Name == typeof(StandaloneDatabase.Models.PurchaseReceive).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x =>
                x.Name == typeof(StandaloneDatabase.Models.PurchaseReturn).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(StandaloneDatabase.Models.Sale).FullName));
            queue.Enqueue(
                entityTypes.FirstOrDefault(x => x.Name == typeof(StandaloneDatabase.Models.Delivery).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x =>
                x.Name == typeof(StandaloneDatabase.Models.SaleReturn).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(TimeSheet).FullName));

            var dailyItems = entityTypes.Where(x => x.Name.Contains(".Daily")).ToList();

            var enumerable = entityTypes.Except(queue.ToList()).ToList();
            enumerable = enumerable.Except(dailyItems).ToList().OrderBy(x => x.Name).ToList();

            foreach (var entityType in enumerable) queue.Enqueue(entityType);

            foreach (var dailyItem in dailyItems) queue.Enqueue(dailyItem);


            foreach (var item in queue)
            {
                #region Handel Exceptions

                if (item.Name == $"{typeof(StandaloneDatabase.Models.AggregatedCounter).FullName}") continue;
                if (item.Name == $"{typeof(StandaloneDatabase.Models.Hash).FullName}") continue;
                if (item.Name == $"{typeof(StandaloneDatabase.Models.Counter).FullName}") continue;
                if (item.Name == $"{typeof(StandaloneDatabase.Models.Job).FullName}") continue;
                if (item.Name == $"{typeof(StandaloneDatabase.Models.JobParameter).FullName}") continue;
                if (item.Name == $"{typeof(StandaloneDatabase.Models.JobQueue).FullName}") continue;
                if (item.Name == $"{typeof(StandaloneDatabase.Models.List).FullName}") continue;
                if (item.Name == $"{typeof(StandaloneDatabase.Models.MigrationHistory).FullName}") continue;
                if (item.Name == $"{typeof(StandaloneDatabase.Models.Schema).FullName}") continue;
                if (item.Name == $"{typeof(StandaloneDatabase.Models.Server).FullName}") continue;
                if (item.Name == $"{typeof(StandaloneDatabase.Models.Set).FullName}") continue;
                if (item.Name == $"{typeof(StandaloneDatabase.Models.State).FullName}") continue;

                if (item.Name == $"{typeof(AspNetRoles).FullName}") continue;
                if (item.Name == $"{typeof(AspNetUserRoles).FullName}") continue;
                if (item.Name == $"{typeof(AspNetPermission).FullName}") continue;
                if (item.Name == $"{typeof(AspNetResource).FullName}") continue;
                if (item.Name == $"{typeof(AspNetUserLogins).FullName}") continue;
                if (item.Name == $"{typeof(AspNetUserClaims).FullName}") continue;

                #endregion

                var sourceType = standaloneDatabaseAssemblyTypes.FirstOrDefault(t => t.FullName == item.Name);
                if (sourceType != null)
                {
                    Migrator.Initialize(new TilesCornerDbContext(_sourceOptionsBuilder.Options),
                        new TilesPadDbContext(_destinationOptionsBuilder.Options));

                    var queryable = Migrator.SourceContext.Set(sourceType);
                    var objects = queryable.ToList();

                    if (objects.Any()) Migrator.Migrate(objects, sourceType);
                }
            }

            #endregion
        }
    }
}