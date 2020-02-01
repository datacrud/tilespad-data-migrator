using System;
using System.Linq;
using System.Reflection;
using Client.Extensions;
using Client.Migrators;
using Client.Providers;
using SaaSDatabase.Models;
using StandaloneDatabase.Models;
using AggregatedCounter = StandaloneDatabase.Models.AggregatedCounter;
using AspNetUserClaims = StandaloneDatabase.Models.AspNetUserClaims;
using AspNetUserLogins = StandaloneDatabase.Models.AspNetUserLogins;
using AspNetUserRoles = StandaloneDatabase.Models.AspNetUserRoles;
using Counter = StandaloneDatabase.Models.Counter;
using Hash = StandaloneDatabase.Models.Hash;
using Job = StandaloneDatabase.Models.Job;
using JobParameter = StandaloneDatabase.Models.JobParameter;
using JobQueue = StandaloneDatabase.Models.JobQueue;
using List = StandaloneDatabase.Models.List;
using MigrationHistory = StandaloneDatabase.Models.MigrationHistory;
using Schema = StandaloneDatabase.Models.Schema;
using Server = StandaloneDatabase.Models.Server;
using Set = StandaloneDatabase.Models.Set;
using State = StandaloneDatabase.Models.State;


namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {

            #region initiatlize

            Migrator.Initialize(new TilesCornerDbContext(), new TilesPadDBContext());

            Console.WriteLine("Enter you tenancy name to start the migration");
            string tenancyName = "tilescorner"; //Console.ReadLine();
            string tenantId = MigrationProvider.GetTenantId(tenancyName);
            var companyId = MigrationProvider.GetCompanyId(tenantId);

            Migrator.Setup(tenantId, companyId);

            Console.WriteLine($"Migration Started at {DateTime.Now}");

            #endregion


           

            #region Read source database entities

            var standaloneDatabaseAssembly = Assembly.Load($"{nameof(StandaloneDatabase)}");
            var standaloneDatabaseAssemblyTypes = standaloneDatabaseAssembly.GetTypes();

            var entityTypes = Migrator.SourceContext.Model.GetEntityTypes();
            foreach (var entityType in entityTypes)
            {
                #region Handel Exceptions

                if(entityType.Name == $"{typeof(AggregatedCounter).FullName}") continue;
                if(entityType.Name == $"{typeof(Hash).FullName}") continue;
                if(entityType.Name == $"{typeof(Counter).FullName}") continue;
                if(entityType.Name == $"{typeof(Job).FullName}") continue;
                if(entityType.Name == $"{typeof(JobParameter).FullName}") continue;
                if(entityType.Name == $"{typeof(JobQueue).FullName}") continue;
                if(entityType.Name == $"{typeof(List).FullName}") continue;
                if(entityType.Name == $"{typeof(MigrationHistory).FullName}") continue;
                if(entityType.Name == $"{typeof(Schema).FullName}") continue;
                if(entityType.Name == $"{typeof(Server).FullName}") continue;
                if(entityType.Name == $"{typeof(Set).FullName}") continue;
                if(entityType.Name == $"{typeof(State).FullName}") continue;

                if(entityType.Name == $"{typeof(AspNetRoles).FullName}") continue;
                if(entityType.Name == $"{typeof(AspNetUserRoles).FullName}") continue;
                if(entityType.Name == $"{typeof(AspNetPermission).FullName}") continue;
                if(entityType.Name == $"{typeof(AspNetResource).FullName}") continue;
                if(entityType.Name == $"{typeof(AspNetUserLogins).FullName}") continue;
                if(entityType.Name == $"{typeof(AspNetUserClaims).FullName}") continue;

                #endregion

                Migrator.SourceContext.ChangeTracker.AutoDetectChangesEnabled = false;

                var sourceType = standaloneDatabaseAssemblyTypes.FirstOrDefault(t => t.FullName == entityType.Name);
                if (sourceType != null)
                {
                    var queryable = Migrator.SourceContext.Set(sourceType);
                    var objects = queryable.ToList();

                    if(objects.Any()) Migrator.Migrate(objects, sourceType);
                }
            }

            #endregion

        }

    }
}
