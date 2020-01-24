using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using AutoMapper;
using Client.Extensions;
using Client.Mappers;
using Microsoft.EntityFrameworkCore.Internal;
using SaaSDatabase.Models;

namespace Client.Migrators
{
    public class Migrator
    {
        private static string TenantId { get; set; }
        private static string CompanyId { get; set; }

        private static readonly TilesPadDbContext TilesPadDbContext = new TilesPadDbContext();

        private static readonly Mapper Mapper = new Mapper(MapperConfig.GetProvider());

        public static void Init(string tenantId, string companyId)
        {
            TenantId = tenantId;
            CompanyId = companyId;
        }


        public static void Migrate(List<object> sourceObjects, string sourceTypeName)
        {
            TilesPadDbContext.ChangeTracker.AutoDetectChangesEnabled = false;

            using (var scope = new TransactionScope())
            {
                if (sourceTypeName == $"{typeof(StandaloneDatabase.Models.Branch)}")
                {
                    var map = Mapper.Map<List<Branch>>(sourceObjects);
                    map.Prepare(TenantId, CompanyId, $"{nameof(Tenant.CreatedBy)}",
                        $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var branch in map)
                    {
                        if (!TilesPadDbContext.Branch.Any(x => x.Id == branch.Id))
                        {
                            TilesPadDbContext.Branch.Add(branch);
                        }
                    }
                }
                //else if (sourceTypeName == $"{typeof(StandaloneDatabase.Models.AspNetUsers)}")
                //{
                //    var map = mapper.Map<List<AspNetUsers>>(sourceObjects);
                //    map.Prepare(tenantId, companyId, $"{nameof(AspNetUsers.CreatedBy)}",
                //        $"{nameof(AspNetUsers.ModifiedBy)}");

                //    tilesPadDbContext.AspNetUsers.AddRange(map);
                //}


                TilesPadDbContext.SaveChanges();

                scope.Complete();
            }

        }
    }
}
