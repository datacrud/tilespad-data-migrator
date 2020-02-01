using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Client.Extensions;
using Client.Migrators;
using Client.Providers;
using Microsoft.EntityFrameworkCore.Metadata;
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
using DepositHead = StandaloneDatabase.Models.DepositHead;
using Employee = StandaloneDatabase.Models.Employee;
using ExpenseHead = StandaloneDatabase.Models.ExpenseHead;
using Hash = StandaloneDatabase.Models.Hash;
using Job = StandaloneDatabase.Models.Job;
using JobParameter = StandaloneDatabase.Models.JobParameter;
using JobQueue = StandaloneDatabase.Models.JobQueue;
using List = StandaloneDatabase.Models.List;
using MigrationHistory = StandaloneDatabase.Models.MigrationHistory;
using Partner = StandaloneDatabase.Models.Partner;
using Product = StandaloneDatabase.Models.Product;
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
        static void Main(string[] args)
        {

            #region initiatlize

            Migrator.Initialize(new TilesCornerDbContext(), new TilesPadDBContext());

            Console.WriteLine("Enter you tenancy name to start the migration");
            Console.WriteLine("tilescorner");
            string tenancyName = "tilescorner"; //Console.ReadLine();
            string tenantId = MigrationProvider.GetTenantId(tenancyName);
            var companyId = MigrationProvider.GetCompanyId(tenantId);

            Migrator.Setup(tenantId, companyId);

            Console.WriteLine($"Migration Started at {DateTime.Now}");

            #endregion


           

            #region Read source database entities

            var standaloneDatabaseAssembly = Assembly.Load($"{nameof(StandaloneDatabase)}");
            var standaloneDatabaseAssemblyTypes = standaloneDatabaseAssembly.GetTypes();

            List<IEntityType> entityTypes = Migrator.SourceContext.Model.GetEntityTypes().OrderBy(x=> x.Name).ToList();
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
            queue.Enqueue(entityTypes.FirstOrDefault(x => x.Name == typeof(ExpenseHead).FullName));

            var dailyItems = entityTypes.Where(x => x.Name.Contains(".Daily")).ToList();

            var enumerable = entityTypes.Except(queue.ToList()).ToList();
            enumerable = enumerable.Except(dailyItems).ToList().OrderBy(x=> x.Name).ToList();

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
                if(item.Name == $"{typeof(Hash).FullName}") continue;
                if(item.Name == $"{typeof(Counter).FullName}") continue;
                if(item.Name == $"{typeof(Job).FullName}") continue;
                if(item.Name == $"{typeof(JobParameter).FullName}") continue;
                if(item.Name == $"{typeof(JobQueue).FullName}") continue;
                if(item.Name == $"{typeof(List).FullName}") continue;
                if(item.Name == $"{typeof(MigrationHistory).FullName}") continue;
                if(item.Name == $"{typeof(Schema).FullName}") continue;
                if(item.Name == $"{typeof(Server).FullName}") continue;
                if(item.Name == $"{typeof(Set).FullName}") continue;
                if(item.Name == $"{typeof(State).FullName}") continue;

                if(item.Name == $"{typeof(AspNetRoles).FullName}") continue;
                if(item.Name == $"{typeof(AspNetUserRoles).FullName}") continue;
                if(item.Name == $"{typeof(AspNetPermission).FullName}") continue;
                if(item.Name == $"{typeof(AspNetResource).FullName}") continue;
                if(item.Name == $"{typeof(AspNetUserLogins).FullName}") continue;
                if(item.Name == $"{typeof(AspNetUserClaims).FullName}") continue;

                #endregion

                var sourceType = standaloneDatabaseAssemblyTypes.FirstOrDefault(t => t.FullName == item.Name);
                if (sourceType != null)
                {
                    Migrator.Initialize(new TilesCornerDbContext(),new TilesPadDBContext());

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
