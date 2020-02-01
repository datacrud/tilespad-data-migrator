using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Transactions;
using AutoMapper;
using Client.Extensions;
using Client.Mappers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using SaaSDatabase.Models;

namespace Client.Migrators
{
    public class Migrator
    {
        private static string TenantId { get; set; }
        private static string CompanyId { get; set; }

        public static DbContext SourceContext { get; private set; }
        public static DbContext DestinationContext { get; private set; }

        private static readonly Mapper Mapper = new Mapper(MapperConfig.GetMapper());

        public static void Initialize(DbContext sourceContext, DbContext destinationContext)
        {
            SourceContext = sourceContext;
            DestinationContext = destinationContext;
        }

        public static void Setup(string tenantId, string companyId)
        {
            TenantId = tenantId;
            CompanyId = companyId;
        }


        public static void Migrate(List<object> sourceObjects, Type sourceType)
        {
            Console.WriteLine($"Migrating {sourceObjects.Count} objects of {sourceType.FullName} ....");
            //var saaSDatabaseAssembly = Assembly.Load($"{nameof(SaaSDatabase)}");
            //var standaloneDatabaseAssemblyTypes = saaSDatabaseAssembly.GetTypes();
            //var split = sourceType.Name.Split(".");
            //var destinationType = standaloneDatabaseAssemblyTypes.FirstOrDefault(t => t.Name.Contains($".{split[split.Length -1]}"));

            //var map = Mapper.Map(sourceObjects, sourceType, destinationType);
            DestinationContext.ChangeTracker.AutoDetectChangesEnabled = false;

            using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, TimeSpan.MaxValue))
            {
                if (sourceType == typeof(StandaloneDatabase.Models.AspNetUsers))
                {
                    var dbSet = DestinationContext.Set<AspNetUsers>();
                    var map = Mapper.Map<List<AspNetUsers>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.Asset))
                {
                    var dbSet = DestinationContext.Set<Asset>();
                    var map = Mapper.Map<List<Asset>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            dbSet.Add(entity);
                        }
                    }
                }


                else if (sourceType == typeof(StandaloneDatabase.Models.Bank))
                {
                    var dbSet = DestinationContext.Set<Bank>();
                    var map = Mapper.Map<List<Bank>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.BankCheck))
                {
                    var dbSet = DestinationContext.Set<BankCheck>();
                    var map = Mapper.Map<List<BankCheck>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            dbSet.Add(entity);
                        }
                    }
                }


                else if (sourceType == typeof(StandaloneDatabase.Models.Branch))
                {
                    var dbSet = DestinationContext.Set<Branch>();
                    var map = Mapper.Map<List<Branch>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.Category))
                {
                    var dbSet = DestinationContext.Set<Category>();
                    var map = Mapper.Map<List<Category>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        if (!dbSet.AsNoTracking().Any(x=> x.Id == entity.Id))
                        {
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.ComissionSetup))
                {
                    var dbSet = DestinationContext.Set<PurchaseCommissionSetup>();
                    var map = Mapper.Map<List<PurchaseCommissionSetup>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.Customer))
                {
                    var dbSet = DestinationContext.Set<Customer>();
                    var map = Mapper.Map<List<Customer>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.DailyBankTransectionalBalance))
                {
                    var dbSet = DestinationContext.Set<DailyBankAccountBalance>();
                    var map = Mapper.Map<List<DailyBankAccountBalance>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.DailyCashTransectionalBalance))
                {
                    var dbSet = DestinationContext.Set<DailyCashAccountBalance>();
                    var map = Mapper.Map<List<DailyCashAccountBalance>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.DailyCustomerTransectionalBalance))
                {
                    var dbSet = DestinationContext.Set<DailyCustomerAccountBalance>();
                    var map = Mapper.Map<List<DailyCustomerAccountBalance>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.DailySupplierTransectionalBalance))
                {
                    var dbSet = DestinationContext.Set<DailySupplierAccountBalance>();
                    var map = Mapper.Map<List<DailySupplierAccountBalance>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.DailyTransectionalBalance))
                {
                    var dbSet = DestinationContext.Set<DailyAccountBalance>();
                    var map = Mapper.Map<List<DailyAccountBalance>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.DailyTransectionalProductStock))
                {
                    var dbSet = DestinationContext.Set<DailyProductStockBalance>();
                    var map = Mapper.Map<List<DailyProductStockBalance>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.DailyTransectionalStock))
                {
                    var dbSet = DestinationContext.Set<DailyStockBalance>();
                    var map = Mapper.Map<List<DailyStockBalance>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.Delivery))
                {
                    var dbSet = DestinationContext.Set<Delivery>();
                    var map = Mapper.Map<List<Delivery>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.DeliveryProduct))
                {
                    var dbSet = DestinationContext.Set<DeliveryProduct>();
                    var map = Mapper.Map<List<DeliveryProduct>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.Deposit))
                {
                    var dbSet = DestinationContext.Set<Deposit>();
                    var map = Mapper.Map<List<Deposit>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.DepositDetail))
                {
                    var dbSet = DestinationContext.Set<DepositDetail>();
                    var map = Mapper.Map<List<DepositDetail>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.DepositHead))
                {
                    var dbSet = DestinationContext.Set<DepositHead>();
                    var map = Mapper.Map<List<DepositHead>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.Employee))
                {
                    var dbSet = DestinationContext.Set<Employee>();
                    var map = Mapper.Map<List<Employee>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            dbSet.Add(entity);
                        }
                    }
                }

               

                DestinationContext.SaveChanges();

                scope.Complete();
            }

        }
    }
}
