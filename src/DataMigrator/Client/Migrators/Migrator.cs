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

            SourceContext.ChangeTracker.AutoDetectChangesEnabled = false;
            SourceContext.ChangeTracker.LazyLoadingEnabled = false;

            DestinationContext.ChangeTracker.AutoDetectChangesEnabled = false;
            DestinationContext.ChangeTracker.LazyLoadingEnabled = false;
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

            using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, TimeSpan.MaxValue))
            {

                if (sourceType == typeof(StandaloneDatabase.Models.AspNetUsers))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<AspNetUsers>();
                    var map = Mapper.Map<List<AspNetUsers>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.Asset))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<Asset>();
                    var map = Mapper.Map<List<Asset>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }


                else if (sourceType == typeof(StandaloneDatabase.Models.Bank))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<Bank>();
                    var map = Mapper.Map<List<Bank>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.BankCheck))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<BankCheck>();
                    var map = Mapper.Map<List<BankCheck>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }


                else if (sourceType == typeof(StandaloneDatabase.Models.Branch))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<Branch>();
                    var map = Mapper.Map<List<Branch>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.Category))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<Category>();
                    var map = Mapper.Map<List<Category>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.ComissionSetup))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<PurchaseCommissionSetup>();
                    var map = Mapper.Map<List<PurchaseCommissionSetup>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.Customer))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<Customer>();
                    var map = Mapper.Map<List<Customer>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!dbSet.AsNoTracking().Any(x => x.Id == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.DailyBankTransectionalBalance))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<DailyBankAccountBalance>();
                    var map = Mapper.Map<List<DailyBankAccountBalance>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.DailyCashTransectionalBalance))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<DailyCashAccountBalance>();
                    var map = Mapper.Map<List<DailyCashAccountBalance>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.DailyCustomerTransectionalBalance))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<DailyCustomerAccountBalance>();
                    var map = Mapper.Map<List<DailyCustomerAccountBalance>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.DailySupplierTransectionalBalance))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<DailySupplierAccountBalance>();
                    var map = Mapper.Map<List<DailySupplierAccountBalance>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.DailyTransectionalBalance))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<DailyAccountBalance>();
                    var map = Mapper.Map<List<DailyAccountBalance>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.DailyTransectionalProductStock))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<DailyProductStockBalance>();
                    var map = Mapper.Map<List<DailyProductStockBalance>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.DailyTransectionalStock))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<DailyStockBalance>();
                    var map = Mapper.Map<List<DailyStockBalance>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.Delivery))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<Delivery>();
                    var map = Mapper.Map<List<Delivery>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.DeliveryProduct))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<DeliveryProduct>();
                    var map = Mapper.Map<List<DeliveryProduct>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.Deposit))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<Deposit>();
                    var map = Mapper.Map<List<Deposit>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.DepositDetail))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<DepositDetail>();
                    var map = Mapper.Map<List<DepositDetail>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.DepositHead))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<DepositHead>();
                    var map = Mapper.Map<List<DepositHead>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.Employee))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<Employee>();
                    var map = Mapper.Map<List<Employee>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }


                else if (sourceType == typeof(StandaloneDatabase.Models.Equity))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<Equity>();
                    var map = Mapper.Map<List<Equity>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.Expense))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<Expense>();
                    var map = Mapper.Map<List<Expense>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.ExpenseDetail))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<ExpenseDetail>();
                    var map = Mapper.Map<List<ExpenseDetail>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.ExpenseHead))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<ExpenseHead>();
                    var map = Mapper.Map<List<ExpenseHead>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.LoginAttempt))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<LoginAttempt>();
                    var map = Mapper.Map<List<LoginAttempt>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }


                else if (sourceType == typeof(StandaloneDatabase.Models.OpeningStock))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<OpeningStock>();
                    var map = Mapper.Map<List<OpeningStock>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.Partner))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<Partner>();
                    var map = Mapper.Map<List<Partner>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.PurchaseOrder))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<PurchaseOrder>();
                    var map = Mapper.Map<List<PurchaseOrder>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.PurchaseOrderPayment))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<PurchaseOrderPayment>();
                    var map = Mapper.Map<List<PurchaseOrderPayment>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.PurchaseOrderProduct))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<PurchaseOrderProduct>();
                    var map = Mapper.Map<List<PurchaseOrderProduct>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }


                else if (sourceType == typeof(StandaloneDatabase.Models.PurchaseReceive))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<PurchaseReceive>();
                    var map = Mapper.Map<List<PurchaseReceive>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.PurchaseReceiveProduct))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<PurchaseReceiveProduct>();
                    var map = Mapper.Map<List<PurchaseReceiveProduct>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }


                else if (sourceType == typeof(StandaloneDatabase.Models.PurchaseReturn))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<PurchaseReturn>();
                    var map = Mapper.Map<List<PurchaseReturn>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }


                else if (sourceType == typeof(StandaloneDatabase.Models.PurchaseReturnProduct))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<PurchaseReturnProduct>();
                    var map = Mapper.Map<List<PurchaseReturnProduct>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }


                else if (sourceType == typeof(StandaloneDatabase.Models.Sale))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<Sale>();
                    var map = Mapper.Map<List<Sale>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.SaleProduct))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<SaleProduct>();
                    var map = Mapper.Map<List<SaleProduct>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.SalePayment))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<SalePayment>();
                    var map = Mapper.Map<List<SalePayment>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }


                else if (sourceType == typeof(StandaloneDatabase.Models.SaleReturn))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<SaleReturn>();
                    var map = Mapper.Map<List<SaleReturn>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.SaleReturnProduct))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<SaleReturnProduct>();
                    var map = Mapper.Map<List<SaleReturnProduct>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }


                else if (sourceType == typeof(StandaloneDatabase.Models.Stock))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<Stock>();
                    var map = Mapper.Map<List<Stock>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }


                else if (sourceType == typeof(StandaloneDatabase.Models.StockTransfer))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<StockTransfer>();
                    var map = Mapper.Map<List<StockTransfer>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.Subcategory))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<Subcategory>();
                    var map = Mapper.Map<List<Subcategory>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }


                else if (sourceType == typeof(StandaloneDatabase.Models.Supplier))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<Supplier>();
                    var map = Mapper.Map<List<Supplier>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }


                else if (sourceType == typeof(StandaloneDatabase.Models.SupplierCategory))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<SupplierCategory>();
                    var map = Mapper.Map<List<SupplierCategory>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.TransectionLog))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<AuditLog>();
                    var map = Mapper.Map<List<AuditLog>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }


                else if (sourceType == typeof(StandaloneDatabase.Models.Warehouse))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<Warehouse>();
                    var map = Mapper.Map<List<Warehouse>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.WestageStock))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<WastageStock>();
                    var map = Mapper.Map<List<WastageStock>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                else if (sourceType == typeof(StandaloneDatabase.Models.Product))
                {
                    var userIds = DestinationContext.Set<AspNetUsers>().AsNoTracking().Select(x => x.Id).ToList();

                    var dbSet = DestinationContext.Set<Product>();
                    var map = Mapper.Map<List<Product>>(sourceObjects);

                    map.Prepare(TenantId, CompanyId, userIds, $"{nameof(Tenant.CreatedBy)}", $"{nameof(Tenant.ModifiedBy)}");

                    var existingItemIds = dbSet.AsNoTracking().Select(x => x.Id).ToList();
                    foreach (var entity in map)
                    {
                        Console.WriteLine($"...... checking {entity.Id} of {sourceType.FullName} ....");
                        if (!existingItemIds.Any(x => x == entity.Id))
                        {
                            Console.WriteLine($"...... confirming {entity.Id} ....");
                            dbSet.Add(entity);
                        }
                    }
                }

                Console.WriteLine($"Saving start at {DateTime.Now} ....");
                DestinationContext.SaveChanges();
                Console.WriteLine($"Saving finished at {DateTime.Now} ....");

                scope.Complete();
            }

        }
    }
}
