using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection;
using AutoMapper;
using Client.Extensions;
using Client.Migrators;
using Client.Providers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SaaSDatabase.Models;
using StandaloneDatabase.Models;
using AggregatedCounter = StandaloneDatabase.Models.AggregatedCounter;
using AspNetUserClaims = StandaloneDatabase.Models.AspNetUserClaims;
using AspNetUserLogins = StandaloneDatabase.Models.AspNetUserLogins;
using AspNetUserRoles = StandaloneDatabase.Models.AspNetUserRoles;
using AspNetUsers = StandaloneDatabase.Models.AspNetUsers;
using Bank = StandaloneDatabase.Models.Bank;
using Branch = StandaloneDatabase.Models.Branch;
using Category = StandaloneDatabase.Models.Category;
using Counter = StandaloneDatabase.Models.Counter;
using Customer = StandaloneDatabase.Models.Customer;
using Delivery = StandaloneDatabase.Models.Delivery;
using Deposit = StandaloneDatabase.Models.Deposit;
using DepositHead = StandaloneDatabase.Models.DepositHead;
using Employee = StandaloneDatabase.Models.Employee;
using Expense = StandaloneDatabase.Models.Expense;
using ExpenseHead = StandaloneDatabase.Models.ExpenseHead;
using Hash = StandaloneDatabase.Models.Hash;
using Job = StandaloneDatabase.Models.Job;
using JobParameter = StandaloneDatabase.Models.JobParameter;
using JobQueue = StandaloneDatabase.Models.JobQueue;
using List = StandaloneDatabase.Models.List;
using MigrationHistory = StandaloneDatabase.Models.MigrationHistory;
using Partner = StandaloneDatabase.Models.Partner;
using Product = StandaloneDatabase.Models.Product;
using PurchaseOrder = StandaloneDatabase.Models.PurchaseOrder;
using PurchaseReceive = StandaloneDatabase.Models.PurchaseReceive;
using PurchaseReturn = StandaloneDatabase.Models.PurchaseReturn;
using Sale = StandaloneDatabase.Models.Sale;
using SaleReturn = StandaloneDatabase.Models.SaleReturn;
using Schema = StandaloneDatabase.Models.Schema;
using Server = StandaloneDatabase.Models.Server;
using Set = StandaloneDatabase.Models.Set;
using State = StandaloneDatabase.Models.State;
using Subcategory = StandaloneDatabase.Models.Subcategory;
using Supplier = StandaloneDatabase.Models.Supplier;
using SupplierCategory = StandaloneDatabase.Models.SupplierCategory;
using Warehouse = StandaloneDatabase.Models.Warehouse;


namespace Client
{
    class Program
    {
        private static DbContextOptionsBuilder<TilesCornerDbContext> _sourceOptionsBuilder;
        private static DbContextOptionsBuilder<TilesPadDbContext> _destinationOptionsBuilder;
        private static IConfigurationRoot _configureServices;

        static void Main(string[] args)
        {
            Console.WriteLine("Initializing...");

            #region Startup

            // Create service collection
            ServiceCollection serviceCollection = new ServiceCollection();
            _configureServices = Startup.ConfigureServices(serviceCollection);

            // Create service provider
            IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
            
            #endregion


            #region initiatlize

            _sourceOptionsBuilder = new DbContextOptionsBuilder<TilesCornerDbContext>();
            _sourceOptionsBuilder.UseSqlServer(_configureServices.GetConnectionString("SourceConnection"));
            Console.WriteLine($"Connected source database....{_configureServices.GetConnectionString("SourceConnection")}");

            _destinationOptionsBuilder = new DbContextOptionsBuilder<TilesPadDbContext>();
            _destinationOptionsBuilder.UseSqlServer(_configureServices.GetConnectionString("DestinationConnection"));
            Console.WriteLine($"Connected target database....{_configureServices.GetConnectionString("DestinationConnection")}");

            Migrator.Initialize(new TilesCornerDbContext(_sourceOptionsBuilder.Options), new TilesPadDbContext(_destinationOptionsBuilder.Options));

            Console.WriteLine("Enter you tenancy name to start the operation");
            string tenancyName = Console.ReadLine();
            string tenantId = MigrationProvider.GetTenantId(tenancyName, _destinationOptionsBuilder);
            var companyId = MigrationProvider.GetCompanyId(tenantId, _destinationOptionsBuilder);

            Migrator.Setup(tenantId, companyId);

            Console.WriteLine($"{tenancyName} is found on SaaS database. What do you want to do now?");
            Console.WriteLine($"1. Migrate \n2. Clean\n3. Exit");

            string action = Console.ReadLine();

            #endregion

            if (action == "1" || action?.ToLower() == "migrate")
            {
                Console.WriteLine($"Please enter the source database name...");
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

                        Migrator.Initialize(new TilesCornerDbContext(_sourceOptionsBuilder.Options), new TilesPadDbContext(_destinationOptionsBuilder.Options));

                        if (Migrator.IsDatabaseExist(Migrator.SourceContext))
                        {
                            Console.WriteLine($"Database found....connection success....");
                            break;
                        }

                    }
                    Console.WriteLine($"Could not find the database with given key, please enter another name to continue.....");
                }

                StartMigration:
                Console.WriteLine($"All are set now, are you sure you want to start migration of {tenancyName} now???.....");
                Console.WriteLine($"\n1. Yes \t2. No \t0. Exit");

                string confirm = Console.ReadLine();

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
                        Console.WriteLine($"Wrong input....");
                        goto StartMigration;
                    }
                }
                else
                {
                    Console.WriteLine($"Wrong input....");
                    goto StartMigration;
                }
            }

            if (action == "2" || action?.ToLower() == "clean")
            {
                StartDeletion:
                Console.WriteLine($"Are you sure you want to delete all data from {tenancyName}???.....");
                Console.WriteLine($"\n1. Yes \t2. No \t0. Exit");

                string confirm = Console.ReadLine();

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
                        Console.WriteLine($"Wrong input....");
                        goto StartDeletion;
                    }
                }
                else
                {
                    Console.WriteLine($"Wrong input....");
                    goto StartDeletion;
                }
                
            }
            if (action == "3" || action?.ToLower() == "exit")
            {
                Console.WriteLine($"Operation exit for {tenancyName}");
            }

        }

        //Delete tenant and all related data from SaaS Database
        private static void DoClean(string tenantId, string companyId)
        {
            List<IEntityType> entityTypes = Migrator.DestinationContext.Model.GetEntityTypes().OrderBy(x => x.Name).ToList();

            var saaSDatabaseAssembly = Assembly.Load($"{nameof(SaaSDatabase)}");
            var saaSDatabaseAssemblyTypes = saaSDatabaseAssembly.GetTypes();

            Stack<IEntityType> stack = new Stack<IEntityType>();

            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SaaSDatabase.Models.Tenant).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SaaSDatabase.Models.AspNetUsers).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SaaSDatabase.Models.Company).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SaaSDatabase.Models.Warehouse).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SaaSDatabase.Models.Branch).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SaaSDatabase.Models.AppRoles).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SaaSDatabase.Models.Bank).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SaaSDatabase.Models.Customer).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SaaSDatabase.Models.Supplier).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SaaSDatabase.Models.Category).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SaaSDatabase.Models.Subcategory).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SaaSDatabase.Models.Product).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SaaSDatabase.Models.SupplierCategory).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SaaSDatabase.Models.Partner).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SaaSDatabase.Models.Employee).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SaaSDatabase.Models.DepositHead).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SaaSDatabase.Models.Deposit).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SaaSDatabase.Models.ExpenseHead).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SaaSDatabase.Models.Expense).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SaaSDatabase.Models.PurchaseOrder).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SaaSDatabase.Models.PurchaseReceive).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SaaSDatabase.Models.PurchaseReturn).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SaaSDatabase.Models.Sale).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SaaSDatabase.Models.Delivery).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SaaSDatabase.Models.SaleReturn).FullName));
            stack.Push(entityTypes.FirstOrDefault(x => x.Name == typeof(SaaSDatabase.Models.TimeSheet).FullName));

            var enumerable = entityTypes.Except(stack.ToList()).ToList();

            foreach (var entityType in enumerable)
            {
                stack.Push(entityType);
            }

            //_destinationOptionsBuilder.UseSqlServer(_configureServices.GetConnectionString("DestinationConnection") + "Foreign Keys=false;");
            Migrator.Initialize(new TilesCornerDbContext(_sourceOptionsBuilder.Options), new TilesPadDbContext(_destinationOptionsBuilder.Options));

            foreach (var item in stack)
            {
                Console.WriteLine($"Traversing  {item.Name}.....");

                if (item.Name == $"{typeof(SaaSDatabase.Models.AggregatedCounter).FullName}") continue;
                if (item.Name == $"{typeof(SaaSDatabase.Models.Hash).FullName}") continue;
                if (item.Name == $"{typeof(SaaSDatabase.Models.Counter).FullName}") continue;
                if (item.Name == $"{typeof(SaaSDatabase.Models.Job).FullName}") continue;
                if (item.Name == $"{typeof(SaaSDatabase.Models.JobParameter).FullName}") continue;
                if (item.Name == $"{typeof(SaaSDatabase.Models.JobQueue).FullName}") continue;
                if (item.Name == $"{typeof(SaaSDatabase.Models.List).FullName}") continue;
                if (item.Name == $"{typeof(SaaSDatabase.Models.MigrationHistory).FullName}") continue;
                if (item.Name == $"{typeof(SaaSDatabase.Models.Schema).FullName}") continue;
                if (item.Name == $"{typeof(SaaSDatabase.Models.Server).FullName}") continue;
                if (item.Name == $"{typeof(SaaSDatabase.Models.Set).FullName}") continue;
                if (item.Name == $"{typeof(SaaSDatabase.Models.State).FullName}") continue;

                if (item.Name == $"{typeof(SaaSDatabase.Models.Edition).FullName}") continue;
                if (item.Name == $"{typeof(SaaSDatabase.Models.Feature).FullName}") continue;
                if (item.Name == $"{typeof(SaaSDatabase.Models.Rfq).FullName}") continue;
                if (item.Name == $"{typeof(SaaSDatabase.Models.HostSetting).FullName}") continue;

                var entityType = saaSDatabaseAssemblyTypes.FirstOrDefault(t => t.FullName == item.Name);
                if (entityType != null)
                {
                    var queryable = Migrator.DestinationContext.Set(entityType);

                    var objects = item.Name == $"{typeof(SaaSDatabase.Models.Tenant).FullName}"
                        ? queryable.Where($"Id==@0", tenantId).ToList()
                        : queryable.Where("TenantId==@0", tenantId).ToList();

                    if (objects.Any())
                    {
                        if (item.Name == $"{typeof(SaaSDatabase.Models.AspNetUsers).FullName}")
                        {
                            var aspNetUserses = Migrator.Mapper.Map<List<SaaSDatabase.Models.AspNetUsers>>(objects);
                            aspNetUserses.ForEach(x=> x.BranchId = null);
                            Migrator.DestinationContext.BulkUpdate(aspNetUserses);
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

            List<IEntityType> entityTypes = Migrator.SourceContext.Model.GetEntityTypes().OrderBy(x => x.Name).ToList();
            Queue<IEntityType> queue = new Queue<IEntityType>();

            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(Warehouse).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(Branch).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(AspNetUsers).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(Bank).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(Customer).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(Supplier).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(Category).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(Subcategory).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(Product).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(SupplierCategory).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(Partner).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(Employee).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(DepositHead).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(Deposit).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(ExpenseHead).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(Expense).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(PurchaseOrder).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(PurchaseReceive).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(PurchaseReturn).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(Sale).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(Delivery).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(SaleReturn).FullName));
            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(TimeSheet).FullName));

            var dailyItems = entityTypes.Where(x => x.Name.Contains(".Daily")).ToList();

            var enumerable = entityTypes.Except(queue.ToList()).ToList();
            enumerable = enumerable.Except(dailyItems).ToList().OrderBy(x => x.Name).ToList();

            foreach (var entityType in enumerable)
            {
                queue.Enqueue(entityType);
            }

            foreach (var dailyItem in dailyItems)
            {
                queue.Enqueue(dailyItem);
            }


            foreach (var item in queue)
            {
                #region Handel Exceptions

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
                    Migrator.Initialize(new TilesCornerDbContext(_sourceOptionsBuilder.Options), new TilesPadDbContext(_destinationOptionsBuilder.Options));

                    var queryable = Migrator.SourceContext.Set(sourceType);
                    var objects = queryable.ToList();

                    if (objects.Any())
                    {
                        Migrator.Migrate(objects, sourceType);
                    }
                }
            }

            #endregion

        }
    }
}
