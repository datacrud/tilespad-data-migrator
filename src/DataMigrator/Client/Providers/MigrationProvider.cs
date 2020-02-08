using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SaaSDatabase.Models;
using StandaloneDatabase.Models;

namespace Client.Providers
{
    public class MigrationProvider
    {

        public static string GetTenantId(string tenancyName,
            DbContextOptionsBuilder<TilesPadDbContext> targetOptionsBuilder)
        {
            using (var db = new TilesPadDbContext(targetOptionsBuilder.Options))
            {
                var tenant = db.Tenant.AsNoTracking().FirstOrDefault(x => x.TenancyName == tenancyName);
                if (tenant != null)
                {
                    return tenant.Id;
                }
                else
                {
                    var message = $"No tenant found with tenant name {tenancyName}";
                    Console.WriteLine(message);
                    throw new Exception(message);
                }
            }

        }

        public static string GetCompanyId(string tenantId,
            DbContextOptionsBuilder<TilesPadDbContext> targetOptionsBuilder)
        {
            using (var db = new TilesPadDbContext(targetOptionsBuilder.Options))
            {
                var company = db.Company.AsNoTracking().FirstOrDefault(x => x.TenantId == tenantId);
                if (company != null)
                {
                    return company.Id;
                }
                else
                {
                    var message = $"No company found for tenant id {tenantId}";
                    Console.WriteLine(message);
                    throw new Exception(message);
                }
            }

        }

    }
}
