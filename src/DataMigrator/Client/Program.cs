using System;
using System.Linq;
using System.Reflection;
using Client.Extensions;
using Client.Migrators;
using Client.Providers;
using StandaloneDatabase.Models;


namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {

            #region initiatlize

            Console.WriteLine("Please you tenancy name to start the migration");
            string tenancyName = Console.ReadLine();
            string tenantId = MigrationProvider.GetTenantId(tenancyName);
            var companyId = MigrationProvider.GetCompanyId(tenantId);

            var tilesCornerDbContext = new TilesCornerDbContext();

            Migrator.Init(tenantId, companyId);

            Console.WriteLine($"Migration Started at {DateTime.Now}");

            #endregion


           

            #region Read source database entities

            var standaloneDatabaseAssembly = Assembly.Load($"{nameof(StandaloneDatabase)}");
            var standaloneDatabaseAssemblyTypes = standaloneDatabaseAssembly.GetTypes();

            var entityTypes = tilesCornerDbContext.Model.GetEntityTypes();
            foreach (var entityType in entityTypes)
            {
                if(entityType.Name == $"{typeof(AggregatedCounter).FullName}") continue;

                tilesCornerDbContext.ChangeTracker.AutoDetectChangesEnabled = false;

                var sourceType = standaloneDatabaseAssemblyTypes.FirstOrDefault(t => t.FullName == entityType.Name);
                if (sourceType != null)
                {
                    var queryable = tilesCornerDbContext.Set(sourceType);
                    var objects = queryable.ToList();

                    Migrator.Migrate(objects, entityType.Name);
                }
            }

            #endregion

        }

    }
}
