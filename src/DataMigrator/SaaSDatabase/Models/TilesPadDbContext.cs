using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SaaSDatabase.Models
{
    public partial class TilesPadDbContext : DbContext
    {
        public TilesPadDbContext()
        {
        }

        public TilesPadDbContext(DbContextOptions<TilesPadDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AggregatedCounter> AggregatedCounter { get; set; }
        public virtual DbSet<AppPermissions> AppPermissions { get; set; }
        public virtual DbSet<AppResources> AppResources { get; set; }
        public virtual DbSet<AppRoles> AppRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Asset> Asset { get; set; }
        public virtual DbSet<AuditLog> AuditLog { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<BankCheck> BankCheck { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CompanySetting> CompanySetting { get; set; }
        public virtual DbSet<Counter> Counter { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddress { get; set; }
        public virtual DbSet<DailyAccountBalance> DailyAccountBalance { get; set; }
        public virtual DbSet<DailyBankAccountBalance> DailyBankAccountBalance { get; set; }
        public virtual DbSet<DailyCashAccountBalance> DailyCashAccountBalance { get; set; }
        public virtual DbSet<DailyCustomerAccountBalance> DailyCustomerAccountBalance { get; set; }
        public virtual DbSet<DailyProductStockBalance> DailyProductStockBalance { get; set; }
        public virtual DbSet<DailyStockBalance> DailyStockBalance { get; set; }
        public virtual DbSet<DailySupplierAccountBalance> DailySupplierAccountBalance { get; set; }
        public virtual DbSet<Delivery> Delivery { get; set; }
        public virtual DbSet<DeliveryProduct> DeliveryProduct { get; set; }
        public virtual DbSet<Deposit> Deposit { get; set; }
        public virtual DbSet<DepositDetail> DepositDetail { get; set; }
        public virtual DbSet<DepositHead> DepositHead { get; set; }
        public virtual DbSet<Edition> Edition { get; set; }
        public virtual DbSet<EmailLog> EmailLog { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Equity> Equity { get; set; }
        public virtual DbSet<Expense> Expense { get; set; }
        public virtual DbSet<ExpenseDetail> ExpenseDetail { get; set; }
        public virtual DbSet<ExpenseHead> ExpenseHead { get; set; }
        public virtual DbSet<Feature> Feature { get; set; }
        public virtual DbSet<FiscalYear> FiscalYear { get; set; }
        public virtual DbSet<Hash> Hash { get; set; }
        public virtual DbSet<HostSetting> HostSetting { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<JobParameter> JobParameter { get; set; }
        public virtual DbSet<JobQueue> JobQueue { get; set; }
        public virtual DbSet<List> List { get; set; }
        public virtual DbSet<LoginAttempt> LoginAttempt { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<MonthlyEmailBalance> MonthlyEmailBalance { get; set; }
        public virtual DbSet<OpeningStock> OpeningStock { get; set; }
        public virtual DbSet<Partner> Partner { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductPrice> ProductPrice { get; set; }
        public virtual DbSet<PurchaseCommissionSetup> PurchaseCommissionSetup { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public virtual DbSet<PurchaseOrderPayment> PurchaseOrderPayment { get; set; }
        public virtual DbSet<PurchaseOrderProduct> PurchaseOrderProduct { get; set; }
        public virtual DbSet<PurchaseReceive> PurchaseReceive { get; set; }
        public virtual DbSet<PurchaseReceiveProduct> PurchaseReceiveProduct { get; set; }
        public virtual DbSet<PurchaseReturn> PurchaseReturn { get; set; }
        public virtual DbSet<PurchaseReturnProduct> PurchaseReturnProduct { get; set; }
        public virtual DbSet<Rfq> Rfq { get; set; }
        public virtual DbSet<Sale> Sale { get; set; }
        public virtual DbSet<SaleCommissionSetup> SaleCommissionSetup { get; set; }
        public virtual DbSet<SalePayment> SalePayment { get; set; }
        public virtual DbSet<SaleProduct> SaleProduct { get; set; }
        public virtual DbSet<SaleReturn> SaleReturn { get; set; }
        public virtual DbSet<SaleReturnProduct> SaleReturnProduct { get; set; }
        public virtual DbSet<Scheduler> Scheduler { get; set; }
        public virtual DbSet<Schema> Schema { get; set; }
        public virtual DbSet<Server> Server { get; set; }
        public virtual DbSet<Set> Set { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<StockTransfer> StockTransfer { get; set; }
        public virtual DbSet<StockTransferOrder> StockTransferOrder { get; set; }
        public virtual DbSet<StockTransferOrderProduct> StockTransferOrderProduct { get; set; }
        public virtual DbSet<StockTransferReceive> StockTransferReceive { get; set; }
        public virtual DbSet<StockTransferReceiveProduct> StockTransferReceiveProduct { get; set; }
        public virtual DbSet<StocklessPurchase> StocklessPurchase { get; set; }
        public virtual DbSet<StocklessPurchaseReturn> StocklessPurchaseReturn { get; set; }
        public virtual DbSet<StocklessSaleReturn> StocklessSaleReturn { get; set; }
        public virtual DbSet<Subcategory> Subcategory { get; set; }
        public virtual DbSet<Subscription> Subscription { get; set; }
        public virtual DbSet<SubscriptionPayment> SubscriptionPayment { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<SupplierCategory> SupplierCategory { get; set; }
        public virtual DbSet<Tenant> Tenant { get; set; }
        public virtual DbSet<TimeLog> TimeLog { get; set; }
        public virtual DbSet<TimeSheet> TimeSheet { get; set; }
        public virtual DbSet<TransferCarrier> TransferCarrier { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }
        public virtual DbSet<WastageStock> WastageStock { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\sqlexpress;Database=TilesPadDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AggregatedCounter>(entity =>
            {
                entity.ToTable("AggregatedCounter", "HangFire");

                entity.HasIndex(e => new { e.Value, e.Key })
                    .HasName("UX_HangFire_CounterAggregated_Key")
                    .IsUnique();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<AppPermissions>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.ResourceId)
                    .HasName("IX_ResourceId");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.ResourceId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AppPermissionsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.AppPermissions_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.AppPermissionsDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.AppPermissions_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AppPermissionsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.AppPermissions_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.AppPermissions)
                    .HasForeignKey(d => d.ResourceId)
                    .HasConstraintName("FK_dbo.AppPermissions_dbo.AppResources_ResourceId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AppPermissions)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AppPermissions_dbo.AppRoles_RoleId");
            });

            modelBuilder.Entity<AppResources>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Route).IsRequired();

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AppResourcesCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.AppResources_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.AppResourcesDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.AppResources_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AppResourcesModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.AppResources_dbo.AspNetUsers_ModifiedBy");
            });

            modelBuilder.Entity<AppRoles>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.Name)
                    .HasName("RoleNameIndex");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AppRolesCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.AppRoles_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.AppRolesDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.AppRoles_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AppRolesModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.AppRoles_dbo.AspNetUsers_ModifiedBy");
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AspNetUserClaimsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.AspNetUserClaimsDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AspNetUserClaimsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaimsUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AspNetUserLoginsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.AspNetUserLoginsDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AspNetUserLoginsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLoginsUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.AspNetUserRolesDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AspNetUserRolesModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AppRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRolesUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.UserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.EmailConfirmationCodeExpireTime).HasColumnType("datetime");

                entity.Property(e => e.LastLoginTime).HasColumnType("datetime");

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.PasswordChangeConfirmationCodeExpireTime).HasColumnType("datetime");

                entity.Property(e => e.PhoneConfirmationCodeExpireTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InverseCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.AspNetUsers_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.InverseDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.AspNetUsers_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.InverseModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.AspNetUsers_dbo.AspNetUsers_ModifiedBy");
            });

            modelBuilder.Entity<Asset>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Asset)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.Asset_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Asset)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.Asset_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AssetCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.Asset_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.AssetDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.Asset_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AssetModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.Asset_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Asset)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.Asset_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<AuditLog>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.AuditLog)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.AuditLog_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.AuditLog)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.AuditLog_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AuditLogCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.AuditLog_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.AuditLogDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.AuditLog_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AuditLogModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.AuditLog_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.AuditLog)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.AuditLog_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.HasIndex(e => e.AccountNumber)
                    .HasName("IX_AccountNumber")
                    .IsUnique();

                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Bank)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.Bank_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Bank)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.Bank_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.BankCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.Bank_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.BankDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.Bank_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.BankModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.Bank_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Bank)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.Bank_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<BankCheck>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CheckDate).HasColumnType("datetime");

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.BankCheck)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.BankCheck_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.BankCheck)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.BankCheck_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.BankCheckCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.BankCheck_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.BankCheckDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.BankCheck_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.BankCheckModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.BankCheck_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.BankCheck)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.BankCheck_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.LinkedWarehouseId)
                    .HasName("IX_LinkedWarehouseId");

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Code).IsRequired();

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.LinkedWarehouseId).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Branch)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.Branch_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.BranchCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.Branch_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.BranchDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.Branch_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.LinkedWarehouse)
                    .WithMany(p => p.Branch)
                    .HasForeignKey(d => d.LinkedWarehouseId)
                    .HasConstraintName("FK_dbo.Branch_dbo.Warehouse_LinkedWarehouseId");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.BranchModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.Branch_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Branch)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.Branch_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Category)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.Category_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CategoryCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.Category_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.CategoryDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.Category_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CategoryModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.Category_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Category)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.Category_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.EmailConfirmationCodeExpireTime).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.PhoneConfirmationCodeExpireTime).HasColumnType("datetime");

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CompanyCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.Company_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.CompanyDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.Company_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CompanyModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.Company_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Company)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.Company_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<CompanySetting>(entity =>
            {
                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.HostingValidTill).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanySetting)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.CompanySetting_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CompanySettingCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.CompanySetting_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.CompanySettingDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.CompanySetting_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CompanySettingModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.CompanySetting_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.CompanySetting)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.CompanySetting_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<Counter>(entity =>
            {
                entity.ToTable("Counter", "HangFire");

                entity.HasIndex(e => new { e.Value, e.Key })
                    .HasName("IX_HangFire_Counter_Key");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.Customer_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.Customer_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CustomerCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.Customer_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.CustomerDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.Customer_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CustomerModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.Customer_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.Customer_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<CustomerAddress>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_CustomerId");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.CustomerId).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.CustomerAddress)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.CustomerAddress_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CustomerAddress)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.CustomerAddress_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CustomerAddressCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.CustomerAddress_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerAddress)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_dbo.CustomerAddress_dbo.Customer_CustomerId");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.CustomerAddressDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.CustomerAddress_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CustomerAddressModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.CustomerAddress_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.CustomerAddress)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.CustomerAddress_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<DailyAccountBalance>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.DailyAccountBalance)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.DailyAccountBalance_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.DailyAccountBalance)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.DailyAccountBalance_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DailyAccountBalanceCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.DailyAccountBalance_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.DailyAccountBalanceDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.DailyAccountBalance_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DailyAccountBalanceModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.DailyAccountBalance_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.DailyAccountBalance)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.DailyAccountBalance_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<DailyBankAccountBalance>(entity =>
            {
                entity.HasIndex(e => e.BankId)
                    .HasName("IX_BankId");

                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BankId).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.DailyBankAccountBalance)
                    .HasForeignKey(d => d.BankId)
                    .HasConstraintName("FK_dbo.DailyBankTransectionalBalance_dbo.Bank_BankId");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.DailyBankAccountBalance)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.DailyBankAccountBalance_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.DailyBankAccountBalance)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.DailyBankAccountBalance_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DailyBankAccountBalanceCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.DailyBankAccountBalance_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.DailyBankAccountBalanceDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.DailyBankAccountBalance_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DailyBankAccountBalanceModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.DailyBankAccountBalance_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.DailyBankAccountBalance)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.DailyBankAccountBalance_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<DailyCashAccountBalance>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.DailyCashAccountBalance)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.DailyCashAccountBalance_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.DailyCashAccountBalance)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.DailyCashAccountBalance_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DailyCashAccountBalanceCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.DailyCashAccountBalance_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.DailyCashAccountBalanceDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.DailyCashAccountBalance_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DailyCashAccountBalanceModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.DailyCashAccountBalance_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.DailyCashAccountBalance)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.DailyCashAccountBalance_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<DailyCustomerAccountBalance>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_CustomerId");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.CustomerId).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.DailyCustomerAccountBalance)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.DailyCustomerAccountBalance_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.DailyCustomerAccountBalance)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.DailyCustomerAccountBalance_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DailyCustomerAccountBalanceCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.DailyCustomerAccountBalance_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.DailyCustomerAccountBalance)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_dbo.DailyCustomerTransectionalBalance_dbo.Customer_CustomerId");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.DailyCustomerAccountBalanceDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.DailyCustomerAccountBalance_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DailyCustomerAccountBalanceModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.DailyCustomerAccountBalance_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.DailyCustomerAccountBalance)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.DailyCustomerAccountBalance_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<DailyProductStockBalance>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.DailyProductStockBalance)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.DailyProductStockBalance_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.DailyProductStockBalance)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.DailyProductStockBalance_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DailyProductStockBalanceCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.DailyProductStockBalance_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.DailyProductStockBalanceDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.DailyProductStockBalance_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DailyProductStockBalanceModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.DailyProductStockBalance_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.DailyProductStockBalance)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.DailyProductStockBalance_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<DailyStockBalance>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.DailyStockBalance)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.DailyStockBalance_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.DailyStockBalance)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.DailyStockBalance_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DailyStockBalanceCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.DailyStockBalance_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.DailyStockBalanceDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.DailyStockBalance_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DailyStockBalanceModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.DailyStockBalance_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.DailyStockBalance)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.DailyStockBalance_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<DailySupplierAccountBalance>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.SupplierId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.DailySupplierAccountBalance)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.DailySupplierAccountBalance_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.DailySupplierAccountBalance)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.DailySupplierAccountBalance_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DailySupplierAccountBalanceCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.DailySupplierAccountBalance_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.DailySupplierAccountBalanceDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.DailySupplierAccountBalance_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DailySupplierAccountBalanceModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.DailySupplierAccountBalance_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.DailySupplierAccountBalance)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_dbo.DailySupplierTransectionalBalance_dbo.Supplier_SupplierId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.DailySupplierAccountBalance)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.DailySupplierAccountBalance_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<Delivery>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_CustomerId");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.SaleId)
                    .HasName("IX_SaleId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.CustomerId).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.EmployeeId).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.SaleId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Delivery)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.Delivery_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Delivery)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.Delivery_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DeliveryCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.Delivery_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Delivery)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_dbo.Delivery_dbo.Customer_CustomerId");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.DeliveryDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.Delivery_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Delivery)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_dbo.Delivery_dbo.Employee_EmployeeId");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DeliveryModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.Delivery_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.Delivery)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_dbo.Delivery_dbo.Sale_SaleId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Delivery)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.Delivery_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<DeliveryProduct>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CategoryId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.DeliveryId)
                    .HasName("IX_DeliveryId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductId");

                entity.HasIndex(e => e.SaleId)
                    .HasName("IX_SaleId");

                entity.HasIndex(e => e.SubcategoryId)
                    .HasName("IX_SubcategoryId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.HasIndex(e => e.WarehouseId)
                    .HasName("IX_WarehouseId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.DeliveryId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.ProductId).HasMaxLength(128);

                entity.Property(e => e.SaleId).HasMaxLength(128);

                entity.Property(e => e.SubcategoryId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.Property(e => e.WarehouseId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.DeliveryProduct)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.DeliveryProduct_dbo.Branch_BranchId");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.DeliveryProduct)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.DeliveryProduct_dbo.Category_CategoryId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.DeliveryProduct)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.DeliveryProduct_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DeliveryProductCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.DeliveryProduct_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.DeliveryProductDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.DeliveryProduct_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.Delivery)
                    .WithMany(p => p.DeliveryProduct)
                    .HasForeignKey(d => d.DeliveryId)
                    .HasConstraintName("FK_dbo.DeliveryProduct_dbo.Delivery_DeliveryId");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DeliveryProductModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.DeliveryProduct_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DeliveryProduct)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.DeliveryProduct_dbo.Product_ProductId");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.DeliveryProduct)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_dbo.DeliveryProduct_dbo.Sale_SaleId");

                entity.HasOne(d => d.Subcategory)
                    .WithMany(p => p.DeliveryProduct)
                    .HasForeignKey(d => d.SubcategoryId)
                    .HasConstraintName("FK_dbo.DeliveryProduct_dbo.Subcategory_SubcategoryId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.DeliveryProduct)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.DeliveryProduct_dbo.Tenant_TenantId");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.DeliveryProduct)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("FK_dbo.DeliveryProduct_dbo.Warehouse_WarehouseId");
            });

            modelBuilder.Entity<Deposit>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.DepositHeadId)
                    .HasName("IX_DepositHeadId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.ParentHeadId)
                    .HasName("IX_ParentHeadId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.DepositHeadId).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.ParentHeadId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Deposit)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.Deposit_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Deposit)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.Deposit_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DepositCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.Deposit_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.DepositDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.Deposit_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.DepositHead)
                    .WithMany(p => p.DepositDepositHead)
                    .HasForeignKey(d => d.DepositHeadId)
                    .HasConstraintName("FK_dbo.Deposit_dbo.DepositHead_DepositHeadId");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DepositModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.Deposit_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.ParentHead)
                    .WithMany(p => p.DepositParentHead)
                    .HasForeignKey(d => d.ParentHeadId)
                    .HasConstraintName("FK_dbo.Deposit_dbo.DepositHead_ParentHeadId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Deposit)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.Deposit_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<DepositDetail>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.DepositId)
                    .HasName("IX_DepositId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.DepositId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.DepositDetail)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.DepositDetail_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.DepositDetail)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.DepositDetail_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DepositDetailCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.DepositDetail_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.DepositDetailDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.DepositDetail_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.Deposit)
                    .WithMany(p => p.DepositDetail)
                    .HasForeignKey(d => d.DepositId)
                    .HasConstraintName("FK_dbo.DepositDetail_dbo.Deposit_DepositId");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DepositDetailModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.DepositDetail_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.DepositDetail)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.DepositDetail_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<DepositHead>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.ParentId)
                    .HasName("IX_ParentId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.ParentId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.DepositHead)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.DepositHead_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.DepositHead)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.DepositHead_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DepositHeadCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.DepositHead_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.DepositHeadDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.DepositHead_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DepositHeadModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.DepositHead_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_dbo.DepositHead_dbo.DepositHead_ParentId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.DepositHead)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.DepositHead_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<Edition>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EditionCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.Edition_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.EditionDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.Edition_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.EditionModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.Edition_dbo.AspNetUsers_ModifiedBy");
            });

            modelBuilder.Entity<EmailLog>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.EmailLog)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.EmailNotificationLog_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.EmailLog)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.EmailNotificationLog_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EmailLogCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.EmailNotificationLog_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.EmailLogDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.EmailNotificationLog_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.EmailLogModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.EmailNotificationLog_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.EmailLog)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.EmailNotificationLog_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.Employee_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.Employee_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EmployeeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.Employee_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.EmployeeDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.Employee_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.EmployeeModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.Employee_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.Employee_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<Equity>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Equity)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.Equity_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Equity)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.Equity_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EquityCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.Equity_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.EquityDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.Equity_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.EquityModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.Equity_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Equity)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.Equity_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<Expense>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.ExpenseHeadId)
                    .HasName("IX_ExpenseHeadId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.ParentHeadId)
                    .HasName("IX_ParentHeadId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.ExpenseHeadId).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.ParentHeadId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Expense)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.Expense_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Expense)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.Expense_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ExpenseCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.Expense_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.ExpenseDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.Expense_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ExpenseHead)
                    .WithMany(p => p.ExpenseExpenseHead)
                    .HasForeignKey(d => d.ExpenseHeadId)
                    .HasConstraintName("FK_dbo.Expense_dbo.ExpenseHead_ExpenseHeadId");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ExpenseModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.Expense_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.ParentHead)
                    .WithMany(p => p.ExpenseParentHead)
                    .HasForeignKey(d => d.ParentHeadId)
                    .HasConstraintName("FK_dbo.Expense_dbo.ExpenseHead_ParentHeadId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Expense)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.Expense_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<ExpenseDetail>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.ExpenseId)
                    .HasName("IX_ExpenseId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.ExpenseId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.ExpenseDetail)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.ExpenseDetail_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ExpenseDetail)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.ExpenseDetail_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ExpenseDetailCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.ExpenseDetail_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.ExpenseDetailDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.ExpenseDetail_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.Expense)
                    .WithMany(p => p.ExpenseDetail)
                    .HasForeignKey(d => d.ExpenseId)
                    .HasConstraintName("FK_dbo.ExpenseDetail_dbo.Expense_ExpenseId");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ExpenseDetailModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.ExpenseDetail_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.ExpenseDetail)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.ExpenseDetail_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<ExpenseHead>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.ParentId)
                    .HasName("IX_ParentId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.ParentId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.ExpenseHead)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.ExpenseHead_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ExpenseHead)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.ExpenseHead_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ExpenseHeadCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.ExpenseHead_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.ExpenseHeadDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.ExpenseHead_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ExpenseHeadModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.ExpenseHead_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_dbo.ExpenseHead_dbo.ExpenseHead_ParentId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.ExpenseHead)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.ExpenseHead_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<Feature>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.EditionId)
                    .HasName("IX_EditionId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.EditionId).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.FeatureCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.Feature_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.FeatureDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.Feature_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.Edition)
                    .WithMany(p => p.Feature)
                    .HasForeignKey(d => d.EditionId)
                    .HasConstraintName("FK_dbo.Feature_dbo.Edition_EditionId");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.FeatureModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.Feature_dbo.AspNetUsers_ModifiedBy");
            });

            modelBuilder.Entity<FiscalYear>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.FiscalYear)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.FiscalYear_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.FiscalYear)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.FiscalYear_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.FiscalYearCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.FiscalYear_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.FiscalYearDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.FiscalYear_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.FiscalYearModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.FiscalYear_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.FiscalYear)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.FiscalYear_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<Hash>(entity =>
            {
                entity.ToTable("Hash", "HangFire");

                entity.HasIndex(e => new { e.ExpireAt, e.Key })
                    .HasName("IX_HangFire_Hash_Key");

                entity.HasIndex(e => new { e.Id, e.ExpireAt })
                    .HasName("IX_HangFire_Hash_ExpireAt");

                entity.HasIndex(e => new { e.Key, e.Field })
                    .HasName("UX_HangFire_Hash_Key_Field")
                    .IsUnique();

                entity.Property(e => e.Field)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<HostSetting>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(128);
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job", "HangFire");

                entity.HasIndex(e => e.StateName)
                    .HasName("IX_HangFire_Job_StateName");

                entity.HasIndex(e => new { e.Id, e.ExpireAt })
                    .HasName("IX_HangFire_Job_ExpireAt");

                entity.Property(e => e.Arguments).IsRequired();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.InvocationData).IsRequired();

                entity.Property(e => e.StateName).HasMaxLength(20);
            });

            modelBuilder.Entity<JobParameter>(entity =>
            {
                entity.ToTable("JobParameter", "HangFire");

                entity.HasIndex(e => new { e.JobId, e.Name })
                    .HasName("IX_HangFire_JobParameter_JobIdAndName");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobParameter)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_JobParameter_Job");
            });

            modelBuilder.Entity<JobQueue>(entity =>
            {
                entity.ToTable("JobQueue", "HangFire");

                entity.HasIndex(e => new { e.Queue, e.FetchedAt })
                    .HasName("IX_HangFire_JobQueue_QueueAndFetchedAt");

                entity.Property(e => e.FetchedAt).HasColumnType("datetime");

                entity.Property(e => e.Queue)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<List>(entity =>
            {
                entity.ToTable("List", "HangFire");

                entity.HasIndex(e => new { e.Id, e.ExpireAt })
                    .HasName("IX_HangFire_List_ExpireAt");

                entity.HasIndex(e => new { e.ExpireAt, e.Value, e.Key })
                    .HasName("IX_HangFire_List_Key");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Value).HasColumnType("nvarchar(max)");
            });

            modelBuilder.Entity<LoginAttempt>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.LoginAttempt)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.LoginAttempt_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.LoginAttempt)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.LoginAttempt_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.LoginAttemptCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.LoginAttempt_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.LoginAttemptDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.LoginAttempt_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.LoginAttemptModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.LoginAttempt_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.LoginAttempt)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.LoginAttempt_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<MonthlyEmailBalance>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.MonthEndDate).HasColumnType("datetime");

                entity.Property(e => e.MonthStartDate).HasColumnType("datetime");

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.MonthlyEmailBalance)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.MonthlyEmailBalance_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.MonthlyEmailBalance)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.MonthlyEmailBalance_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MonthlyEmailBalanceCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.MonthlyEmailBalance_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.MonthlyEmailBalanceDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.MonthlyEmailBalance_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.MonthlyEmailBalanceModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.MonthlyEmailBalance_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.MonthlyEmailBalance)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.MonthlyEmailBalance_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<OpeningStock>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CategoryId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductId");

                entity.HasIndex(e => e.SubcategoryId)
                    .HasName("IX_SubcategoryId");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.HasIndex(e => e.WarehouseId)
                    .HasName("IX_WarehouseId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.ProductId).HasMaxLength(128);

                entity.Property(e => e.SubcategoryId).HasMaxLength(128);

                entity.Property(e => e.SupplierId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.Property(e => e.WarehouseId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.OpeningStock)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.OpeningStock_dbo.Branch_BranchId");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.OpeningStock)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.OpeningStock_dbo.Category_CategoryId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.OpeningStock)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.OpeningStock_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.OpeningStockCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.OpeningStock_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.OpeningStockDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.OpeningStock_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.OpeningStockModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.OpeningStock_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OpeningStock)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.OpeningStock_dbo.Product_ProductId");

                entity.HasOne(d => d.Subcategory)
                    .WithMany(p => p.OpeningStock)
                    .HasForeignKey(d => d.SubcategoryId)
                    .HasConstraintName("FK_dbo.OpeningStock_dbo.Subcategory_SubcategoryId");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.OpeningStock)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_dbo.OpeningStock_dbo.Supplier_SupplierId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.OpeningStock)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.OpeningStock_dbo.Tenant_TenantId");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.OpeningStock)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("FK_dbo.OpeningStock_dbo.Warehouse_WarehouseId");
            });

            modelBuilder.Entity<Partner>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.PartnerFrom).HasColumnType("datetime");

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Partner)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.Partner_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Partner)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.Partner_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PartnerCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.Partner_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.PartnerDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.Partner_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PartnerModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.Partner_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Partner)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.Partner_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CategoryId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.SubcategoryId)
                    .HasName("IX_SubcategoryId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.Code).IsRequired();

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.SubcategoryId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.Product_dbo.Category_CategoryId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.Product_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ProductCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.Product_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.ProductDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.Product_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ProductModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.Product_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Subcategory)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.SubcategoryId)
                    .HasConstraintName("FK_dbo.Product_dbo.Subcategory_SubcategoryId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.Product_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<ProductPrice>(entity =>
            {
                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductId");

                entity.HasIndex(e => e.PurchaseOrderId)
                    .HasName("IX_PurchaseOrderId");

                entity.HasIndex(e => e.PurchaseReceiveId)
                    .HasName("IX_PurchaseReceiveId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.ProductId).HasMaxLength(128);

                entity.Property(e => e.PurchaseOrderId).HasMaxLength(128);

                entity.Property(e => e.PurchaseReceiveId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ProductPrice)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.ProductPrice_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ProductPriceCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.ProductPrice_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.ProductPriceDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.ProductPrice_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ProductPriceModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.ProductPrice_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductPrice)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.ProductPrice_dbo.Product_ProductId");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.ProductPrice)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .HasConstraintName("FK_dbo.ProductPrice_dbo.PurchaseOrder_PurchaseOrderId");

                entity.HasOne(d => d.PurchaseReceive)
                    .WithMany(p => p.ProductPrice)
                    .HasForeignKey(d => d.PurchaseReceiveId)
                    .HasConstraintName("FK_dbo.ProductPrice_dbo.PurchaseReceive_PurchaseReceiveId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.ProductPrice)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.ProductPrice_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<PurchaseCommissionSetup>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.SupplierId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.PurchaseCommissionSetup)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.PurchaseCommissionSetup_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.PurchaseCommissionSetup)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.PurchaseCommissionSetup_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PurchaseCommissionSetupCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.PurchaseCommissionSetup_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.PurchaseCommissionSetupDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.PurchaseCommissionSetup_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PurchaseCommissionSetupModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.PurchaseCommissionSetup_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PurchaseCommissionSetup)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_dbo.ComissionSetup_dbo.Supplier_SupplierId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.PurchaseCommissionSetup)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.PurchaseCommissionSetup_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<PurchaseOrder>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.EmployeeId).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.SupplierId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.PurchaseOrder)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.PurchaseOrder_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.PurchaseOrder)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.PurchaseOrder_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PurchaseOrderCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.PurchaseOrder_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.PurchaseOrderDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.PurchaseOrder_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PurchaseOrder)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_dbo.PurchaseOrder_dbo.Employee_EmployeeId");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PurchaseOrderModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.PurchaseOrder_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PurchaseOrder)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_dbo.PurchaseOrder_dbo.Supplier_SupplierId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.PurchaseOrder)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.PurchaseOrder_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<PurchaseOrderPayment>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.PurchaseOrderId)
                    .HasName("IX_PurchaseOrderId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.PurchaseOrderId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.PurchaseOrderPayment)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.PurchaseOrderPayment_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.PurchaseOrderPayment)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.PurchaseOrderPayment_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PurchaseOrderPaymentCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.PurchaseOrderPayment_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.PurchaseOrderPaymentDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.PurchaseOrderPayment_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PurchaseOrderPaymentModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.PurchaseOrderPayment_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.PurchaseOrderPayment)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .HasConstraintName("FK_dbo.PurchaseOrderPayment_dbo.PurchaseOrder_PurchaseOrderId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.PurchaseOrderPayment)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.PurchaseOrderPayment_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<PurchaseOrderProduct>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CategoryId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductId");

                entity.HasIndex(e => e.PurchaseOrderId)
                    .HasName("IX_PurchaseOrderId");

                entity.HasIndex(e => e.SubcategoryId)
                    .HasName("IX_SubcategoryId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.ProductId).HasMaxLength(128);

                entity.Property(e => e.PurchaseOrderId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.SubcategoryId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.PurchaseOrderProduct)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.PurchaseOrderProduct_dbo.Branch_BranchId");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.PurchaseOrderProduct)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.PurchaseOrderProduct_dbo.Category_CategoryId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.PurchaseOrderProduct)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.PurchaseOrderProduct_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PurchaseOrderProductCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.PurchaseOrderProduct_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.PurchaseOrderProductDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.PurchaseOrderProduct_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PurchaseOrderProductModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.PurchaseOrderProduct_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.PurchaseOrderProduct)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.PurchaseOrderProduct_dbo.Product_ProductId");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.PurchaseOrderProduct)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .HasConstraintName("FK_dbo.PurchaseOrderProduct_dbo.PurchaseOrder_PurchaseOrderId");

                entity.HasOne(d => d.Subcategory)
                    .WithMany(p => p.PurchaseOrderProduct)
                    .HasForeignKey(d => d.SubcategoryId)
                    .HasConstraintName("FK_dbo.PurchaseOrderProduct_dbo.Subcategory_SubcategoryId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.PurchaseOrderProduct)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.PurchaseOrderProduct_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<PurchaseReceive>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.OrderedEmployeeId)
                    .HasName("IX_OrderedEmployeeId");

                entity.HasIndex(e => e.PurchaseOrderId)
                    .HasName("IX_PurchaseOrderId");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.EmployeeId).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.OrderedEmployeeId).HasMaxLength(128);

                entity.Property(e => e.PurchaseOrderId).HasMaxLength(128);

                entity.Property(e => e.SupplierId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.PurchaseReceive)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.PurchaseReceive_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.PurchaseReceive)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.PurchaseReceive_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PurchaseReceiveCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.PurchaseReceive_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.PurchaseReceiveDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.PurchaseReceive_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PurchaseReceiveEmployee)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_dbo.PurchaseReceive_dbo.Employee_EmployeeId");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PurchaseReceiveModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.PurchaseReceive_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.OrderedEmployee)
                    .WithMany(p => p.PurchaseReceiveOrderedEmployee)
                    .HasForeignKey(d => d.OrderedEmployeeId)
                    .HasConstraintName("FK_dbo.PurchaseReceive_dbo.Employee_OrderedEmployeeId");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.PurchaseReceive)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .HasConstraintName("FK_dbo.PurchaseReceive_dbo.PurchaseOrder_PurchaseOrderId");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PurchaseReceive)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_dbo.PurchaseReceive_dbo.Supplier_SupplierId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.PurchaseReceive)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.PurchaseReceive_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<PurchaseReceiveProduct>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CategoryId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductId");

                entity.HasIndex(e => e.PurchaseOrderId)
                    .HasName("IX_PurchaseOrderId");

                entity.HasIndex(e => e.PurchaseReceiveId)
                    .HasName("IX_PurchaseReceiveId");

                entity.HasIndex(e => e.SubcategoryId)
                    .HasName("IX_SubcategoryId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.HasIndex(e => e.WarehouseId)
                    .HasName("IX_WarehouseId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.ProductId).HasMaxLength(128);

                entity.Property(e => e.PurchaseOrderId).HasMaxLength(128);

                entity.Property(e => e.PurchaseReceiveId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.SubcategoryId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.Property(e => e.WarehouseId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.PurchaseReceiveProduct)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.PurchaseReceiveProduct_dbo.Branch_BranchId");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.PurchaseReceiveProduct)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.PurchaseReceiveProduct_dbo.Category_CategoryId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.PurchaseReceiveProduct)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.PurchaseReceiveProduct_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PurchaseReceiveProductCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.PurchaseReceiveProduct_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.PurchaseReceiveProductDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.PurchaseReceiveProduct_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PurchaseReceiveProductModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.PurchaseReceiveProduct_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.PurchaseReceiveProduct)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.PurchaseReceiveProduct_dbo.Product_ProductId");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.PurchaseReceiveProduct)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .HasConstraintName("FK_dbo.PurchaseReceiveProduct_dbo.PurchaseOrder_PurchaseOrderId");

                entity.HasOne(d => d.PurchaseReceive)
                    .WithMany(p => p.PurchaseReceiveProduct)
                    .HasForeignKey(d => d.PurchaseReceiveId)
                    .HasConstraintName("FK_dbo.PurchaseReceiveProduct_dbo.PurchaseReceive_PurchaseReceiveId");

                entity.HasOne(d => d.Subcategory)
                    .WithMany(p => p.PurchaseReceiveProduct)
                    .HasForeignKey(d => d.SubcategoryId)
                    .HasConstraintName("FK_dbo.PurchaseReceiveProduct_dbo.Subcategory_SubcategoryId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.PurchaseReceiveProduct)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.PurchaseReceiveProduct_dbo.Tenant_TenantId");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.PurchaseReceiveProduct)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("FK_dbo.PurchaseReceiveProduct_dbo.Warehouse_WarehouseId");
            });

            modelBuilder.Entity<PurchaseReturn>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.EmployeeId).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.SupplierId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.PurchaseReturn)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.PurchaseReturn_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.PurchaseReturn)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.PurchaseReturn_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PurchaseReturnCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.PurchaseReturn_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.PurchaseReturnDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.PurchaseReturn_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PurchaseReturn)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_dbo.PurchaseReturn_dbo.Employee_EmployeeId");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PurchaseReturnModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.PurchaseReturn_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PurchaseReturn)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_dbo.PurchaseReturn_dbo.Supplier_SupplierId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.PurchaseReturn)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.PurchaseReturn_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<PurchaseReturnProduct>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CategoryId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductId");

                entity.HasIndex(e => e.PurchaseReturnId)
                    .HasName("IX_PurchaseReturnId");

                entity.HasIndex(e => e.SubcategoryId)
                    .HasName("IX_SubcategoryId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.HasIndex(e => e.WarehouseId)
                    .HasName("IX_WarehouseId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.ProductId).HasMaxLength(128);

                entity.Property(e => e.PurchaseReturnId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.SubcategoryId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.Property(e => e.WarehouseId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.PurchaseReturnProduct)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.PurchaseReturnProduct_dbo.Branch_BranchId");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.PurchaseReturnProduct)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.PurchaseReturnProduct_dbo.Category_CategoryId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.PurchaseReturnProduct)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.PurchaseReturnProduct_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PurchaseReturnProductCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.PurchaseReturnProduct_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.PurchaseReturnProductDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.PurchaseReturnProduct_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PurchaseReturnProductModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.PurchaseReturnProduct_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.PurchaseReturnProduct)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.PurchaseReturnProduct_dbo.Product_ProductId");

                entity.HasOne(d => d.PurchaseReturn)
                    .WithMany(p => p.PurchaseReturnProduct)
                    .HasForeignKey(d => d.PurchaseReturnId)
                    .HasConstraintName("FK_dbo.PurchaseReturnProduct_dbo.PurchaseReturn_PurchaseReturnId");

                entity.HasOne(d => d.Subcategory)
                    .WithMany(p => p.PurchaseReturnProduct)
                    .HasForeignKey(d => d.SubcategoryId)
                    .HasConstraintName("FK_dbo.PurchaseReturnProduct_dbo.Subcategory_SubcategoryId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.PurchaseReturnProduct)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.PurchaseReturnProduct_dbo.Tenant_TenantId");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.PurchaseReturnProduct)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("FK_dbo.PurchaseReturnProduct_dbo.Warehouse_WarehouseId");
            });

            modelBuilder.Entity<Rfq>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.WhatIneed).HasColumnName("WhatINeed");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.RfqCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.Rfq_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.RfqDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.Rfq_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.RfqModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.Rfq_dbo.AspNetUsers_ModifiedBy");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_CustomerId");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.SaleReferenceId)
                    .HasName("IX_SaleReferenceId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.CustomerId).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.SaleReferenceId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Sale)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.Sale_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Sale)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.Sale_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SaleCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.Sale_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Sale)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_dbo.Sale_dbo.Customer_CustomerId");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.SaleDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.Sale_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SaleModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.Sale_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.SaleReference)
                    .WithMany(p => p.Sale)
                    .HasForeignKey(d => d.SaleReferenceId)
                    .HasConstraintName("FK_dbo.Sale_dbo.Employee_SaleReferenceId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Sale)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.Sale_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<SaleCommissionSetup>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.EmployeeId).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.SaleCommissionSetup)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.SaleCommissionSetup_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SaleCommissionSetup)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.SaleCommissionSetup_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SaleCommissionSetupCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.SaleCommissionSetup_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.SaleCommissionSetupDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.SaleCommissionSetup_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.SaleCommissionSetup)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_dbo.SaleCommissionSetup_dbo.Employee_EmployeeId");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SaleCommissionSetupModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.SaleCommissionSetup_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.SaleCommissionSetup)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.SaleCommissionSetup_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<SalePayment>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.SaleId)
                    .HasName("IX_SaleId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.SaleId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.SalePayment)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.SalePayment_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SalePayment)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.SalePayment_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SalePaymentCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.SalePayment_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.SalePaymentDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.SalePayment_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SalePaymentModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.SalePayment_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SalePayment)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_dbo.SalePayment_dbo.Sale_SaleId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.SalePayment)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.SalePayment_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<SaleProduct>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CategoryId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductId");

                entity.HasIndex(e => e.SaleId)
                    .HasName("IX_SaleId");

                entity.HasIndex(e => e.SubcategoryId)
                    .HasName("IX_SubcategoryId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.ProductId).HasMaxLength(128);

                entity.Property(e => e.SaleId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.SubcategoryId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.SaleProduct)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.SaleProduct_dbo.Branch_BranchId");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SaleProduct)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.SaleProduct_dbo.Category_CategoryId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SaleProduct)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.SaleProduct_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SaleProductCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.SaleProduct_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.SaleProductDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.SaleProduct_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SaleProductModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.SaleProduct_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SaleProduct)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.SaleProduct_dbo.Product_ProductId");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleProduct)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_dbo.SaleProduct_dbo.Sale_SaleId");

                entity.HasOne(d => d.Subcategory)
                    .WithMany(p => p.SaleProduct)
                    .HasForeignKey(d => d.SubcategoryId)
                    .HasConstraintName("FK_dbo.SaleProduct_dbo.Subcategory_SubcategoryId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.SaleProduct)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.SaleProduct_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<SaleReturn>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_CustomerId");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.CustomerId).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.EmployeeId).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.SaleReturn)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.SaleReturn_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SaleReturn)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.SaleReturn_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SaleReturnCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.SaleReturn_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SaleReturn)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_dbo.SaleReturn_dbo.Customer_CustomerId");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.SaleReturnDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.SaleReturn_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.SaleReturn)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_dbo.SaleReturn_dbo.Employee_EmployeeId");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SaleReturnModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.SaleReturn_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.SaleReturn)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.SaleReturn_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<SaleReturnProduct>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CategoryId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductId");

                entity.HasIndex(e => e.SaleReturnId)
                    .HasName("IX_SaleReturnId");

                entity.HasIndex(e => e.SubcategoryId)
                    .HasName("IX_SubcategoryId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.HasIndex(e => e.WarehouseId)
                    .HasName("IX_WarehouseId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.ProductId).HasMaxLength(128);

                entity.Property(e => e.SaleReturnId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.SubcategoryId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.Property(e => e.WarehouseId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.SaleReturnProduct)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.SaleReturnProduct_dbo.Branch_BranchId");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SaleReturnProduct)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.SaleReturnProduct_dbo.Category_CategoryId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SaleReturnProduct)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.SaleReturnProduct_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SaleReturnProductCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.SaleReturnProduct_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.SaleReturnProductDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.SaleReturnProduct_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SaleReturnProductModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.SaleReturnProduct_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SaleReturnProduct)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.SaleReturnProduct_dbo.Product_ProductId");

                entity.HasOne(d => d.SaleReturn)
                    .WithMany(p => p.SaleReturnProduct)
                    .HasForeignKey(d => d.SaleReturnId)
                    .HasConstraintName("FK_dbo.SaleReturnProduct_dbo.SaleReturn_SaleReturnId");

                entity.HasOne(d => d.Subcategory)
                    .WithMany(p => p.SaleReturnProduct)
                    .HasForeignKey(d => d.SubcategoryId)
                    .HasConstraintName("FK_dbo.SaleReturnProduct_dbo.Subcategory_SubcategoryId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.SaleReturnProduct)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.SaleReturnProduct_dbo.Tenant_TenantId");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.SaleReturnProduct)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("FK_dbo.SaleReturnProduct_dbo.Warehouse_WarehouseId");
            });

            modelBuilder.Entity<Scheduler>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LastRunTime).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.NextRunTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Scheduler)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.Scheduler_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Scheduler)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.Scheduler_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SchedulerCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.Scheduler_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.SchedulerDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.Scheduler_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SchedulerModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.Scheduler_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Scheduler)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.Scheduler_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<Schema>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PK_HangFire_Schema");

                entity.ToTable("Schema", "HangFire");

                entity.Property(e => e.Version).ValueGeneratedNever();
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.ToTable("Server", "HangFire");

                entity.Property(e => e.Id).HasMaxLength(100);

                entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
            });

            modelBuilder.Entity<Set>(entity =>
            {
                entity.ToTable("Set", "HangFire");

                entity.HasIndex(e => new { e.Id, e.ExpireAt })
                    .HasName("IX_HangFire_Set_ExpireAt");

                entity.HasIndex(e => new { e.Key, e.Value })
                    .HasName("UX_HangFire_Set_KeyAndValue")
                    .IsUnique();

                entity.HasIndex(e => new { e.ExpireAt, e.Value, e.Key })
                    .HasName("IX_HangFire_Set_Key");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.ToTable("State", "HangFire");

                entity.HasIndex(e => e.JobId)
                    .HasName("IX_HangFire_State_JobId");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.State)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_State_Job");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CategoryId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductId");

                entity.HasIndex(e => e.SubcategoryId)
                    .HasName("IX_SubcategoryId");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.HasIndex(e => e.WarehouseId)
                    .HasName("IX_WarehouseId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.ProductId).HasMaxLength(128);

                entity.Property(e => e.SubcategoryId).HasMaxLength(128);

                entity.Property(e => e.SupplierId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.Property(e => e.WarehouseId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Stock)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.Stock_dbo.Branch_BranchId");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Stock)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.Stock_dbo.Category_CategoryId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Stock)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.Stock_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.StockCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.Stock_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.StockDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.Stock_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.StockModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.Stock_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Stock)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.Stock_dbo.Product_ProductId");

                entity.HasOne(d => d.Subcategory)
                    .WithMany(p => p.Stock)
                    .HasForeignKey(d => d.SubcategoryId)
                    .HasConstraintName("FK_dbo.Stock_dbo.Subcategory_SubcategoryId");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Stock)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_dbo.Stock_dbo.Supplier_SupplierId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Stock)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.Stock_dbo.Tenant_TenantId");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.Stock)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("FK_dbo.Stock_dbo.Warehouse_WarehouseId");
            });

            modelBuilder.Entity<StockTransfer>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CategoryId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.DestinationWarehouseId)
                    .HasName("IX_DestinationWarehouseId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductId");

                entity.HasIndex(e => e.SourceWarehouseId)
                    .HasName("IX_SourceWarehouseId");

                entity.HasIndex(e => e.SubcategoryId)
                    .HasName("IX_SubcategoryId");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.DestinationWarehouseId).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.ProductId).HasMaxLength(128);

                entity.Property(e => e.SourceWarehouseId).HasMaxLength(128);

                entity.Property(e => e.SubcategoryId).HasMaxLength(128);

                entity.Property(e => e.SupplierId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.StockTransfer)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.StockTransfer_dbo.Branch_BranchId");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.StockTransfer)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.StockTransfer_dbo.Category_CategoryId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.StockTransfer)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.StockTransfer_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.StockTransferCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.StockTransfer_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.StockTransferDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.StockTransfer_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.DestinationWarehouse)
                    .WithMany(p => p.StockTransferDestinationWarehouse)
                    .HasForeignKey(d => d.DestinationWarehouseId)
                    .HasConstraintName("FK_dbo.StockTransfer_dbo.Warehouse_DestinationWarehouseId");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.StockTransferModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.StockTransfer_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.StockTransfer)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.StockTransfer_dbo.Product_ProductId");

                entity.HasOne(d => d.SourceWarehouse)
                    .WithMany(p => p.StockTransferSourceWarehouse)
                    .HasForeignKey(d => d.SourceWarehouseId)
                    .HasConstraintName("FK_dbo.StockTransfer_dbo.Warehouse_SourceWarehouseId");

                entity.HasOne(d => d.Subcategory)
                    .WithMany(p => p.StockTransfer)
                    .HasForeignKey(d => d.SubcategoryId)
                    .HasConstraintName("FK_dbo.StockTransfer_dbo.Subcategory_SubcategoryId");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.StockTransfer)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_dbo.StockTransfer_dbo.Supplier_SupplierId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.StockTransfer)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.StockTransfer_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<StockTransferOrder>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.DestinationWarehouseId)
                    .HasName("IX_DestinationWarehouseId");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.SourceWarehouseId)
                    .HasName("IX_SourceWarehouseId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.HasIndex(e => e.TransferCarrierId)
                    .HasName("IX_TransferCarrierId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.ApproxTransferArrivalDate).HasColumnType("datetime");

                entity.Property(e => e.ApproxTransferDepartureDate).HasColumnType("datetime");

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.DestinationWarehouseId).HasMaxLength(128);

                entity.Property(e => e.EmployeeId).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.SourceWarehouseId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.Property(e => e.TransferCarrierId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.StockTransferOrder)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.StockTransferOrder_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.StockTransferOrder)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.StockTransferOrder_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.StockTransferOrderCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.StockTransferOrder_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.StockTransferOrderDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.StockTransferOrder_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.DestinationWarehouse)
                    .WithMany(p => p.StockTransferOrderDestinationWarehouse)
                    .HasForeignKey(d => d.DestinationWarehouseId)
                    .HasConstraintName("FK_dbo.StockTransferOrder_dbo.Warehouse_DestinationWarehouseId");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.StockTransferOrder)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_dbo.StockTransferOrder_dbo.Employee_EmployeeId");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.StockTransferOrderModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.StockTransferOrder_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.SourceWarehouse)
                    .WithMany(p => p.StockTransferOrderSourceWarehouse)
                    .HasForeignKey(d => d.SourceWarehouseId)
                    .HasConstraintName("FK_dbo.StockTransferOrder_dbo.Warehouse_SourceWarehouseId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.StockTransferOrder)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.StockTransferOrder_dbo.Tenant_TenantId");

                entity.HasOne(d => d.TransferCarrier)
                    .WithMany(p => p.StockTransferOrder)
                    .HasForeignKey(d => d.TransferCarrierId)
                    .HasConstraintName("FK_dbo.StockTransferOrder_dbo.TransferCarrier_TransferCarrierId");
            });

            modelBuilder.Entity<StockTransferOrderProduct>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductId");

                entity.HasIndex(e => e.StockTransferOrderId)
                    .HasName("IX_StockTransferOrderId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.ProductId).HasMaxLength(128);

                entity.Property(e => e.StockTransferOrderId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.StockTransferOrderProduct)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.StockTransferOrderProduct_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.StockTransferOrderProduct)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.StockTransferOrderProduct_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.StockTransferOrderProductCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.StockTransferOrderProduct_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.StockTransferOrderProductDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.StockTransferOrderProduct_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.StockTransferOrderProductModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.StockTransferOrderProduct_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.StockTransferOrderProduct)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.StockTransferOrderProduct_dbo.Product_ProductId");

                entity.HasOne(d => d.StockTransferOrder)
                    .WithMany(p => p.StockTransferOrderProduct)
                    .HasForeignKey(d => d.StockTransferOrderId)
                    .HasConstraintName("FK_dbo.StockTransferOrderProduct_dbo.StockTransferOrder_StockTransferOrderId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.StockTransferOrderProduct)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.StockTransferOrderProduct_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<StockTransferReceive>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.DestinationWarehouseId)
                    .HasName("IX_DestinationWarehouseId");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.SourceWarehouseId)
                    .HasName("IX_SourceWarehouseId");

                entity.HasIndex(e => e.StockTransferOrderId)
                    .HasName("IX_StockTransferOrderId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.DestinationWarehouseId).HasMaxLength(128);

                entity.Property(e => e.EmployeeId).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.SourceWarehouseId).HasMaxLength(128);

                entity.Property(e => e.StockTransferOrderId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.StockTransferReceive)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.StockTransferReceive_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.StockTransferReceive)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.StockTransferReceive_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.StockTransferReceiveCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.StockTransferReceive_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.StockTransferReceiveDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.StockTransferReceive_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.DestinationWarehouse)
                    .WithMany(p => p.StockTransferReceiveDestinationWarehouse)
                    .HasForeignKey(d => d.DestinationWarehouseId)
                    .HasConstraintName("FK_dbo.StockTransferReceive_dbo.Warehouse_DestinationWarehouseId");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.StockTransferReceive)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_dbo.StockTransferReceive_dbo.Employee_EmployeeId");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.StockTransferReceiveModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.StockTransferReceive_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.SourceWarehouse)
                    .WithMany(p => p.StockTransferReceiveSourceWarehouse)
                    .HasForeignKey(d => d.SourceWarehouseId)
                    .HasConstraintName("FK_dbo.StockTransferReceive_dbo.Warehouse_SourceWarehouseId");

                entity.HasOne(d => d.StockTransferOrder)
                    .WithMany(p => p.StockTransferReceive)
                    .HasForeignKey(d => d.StockTransferOrderId)
                    .HasConstraintName("FK_dbo.StockTransferReceive_dbo.StockTransferOrder_StockTransferOrderId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.StockTransferReceive)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.StockTransferReceive_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<StockTransferReceiveProduct>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.DestinationWarehouseId)
                    .HasName("IX_DestinationWarehouseId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductId");

                entity.HasIndex(e => e.SourceWarehouseId)
                    .HasName("IX_SourceWarehouseId");

                entity.HasIndex(e => e.StockTransferReceiveId)
                    .HasName("IX_StockTransferReceiveId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.DestinationWarehouseId).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.ProductId).HasMaxLength(128);

                entity.Property(e => e.SourceWarehouseId).HasMaxLength(128);

                entity.Property(e => e.StockTransferReceiveId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.StockTransferReceiveProduct)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.StockTransferReceiveProduct_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.StockTransferReceiveProduct)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.StockTransferReceiveProduct_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.StockTransferReceiveProductCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.StockTransferReceiveProduct_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.StockTransferReceiveProductDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.StockTransferReceiveProduct_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.DestinationWarehouse)
                    .WithMany(p => p.StockTransferReceiveProductDestinationWarehouse)
                    .HasForeignKey(d => d.DestinationWarehouseId)
                    .HasConstraintName("FK_dbo.StockTransferReceiveProduct_dbo.Warehouse_DestinationWarehouseId");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.StockTransferReceiveProductModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.StockTransferReceiveProduct_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.StockTransferReceiveProduct)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.StockTransferReceiveProduct_dbo.Product_ProductId");

                entity.HasOne(d => d.SourceWarehouse)
                    .WithMany(p => p.StockTransferReceiveProductSourceWarehouse)
                    .HasForeignKey(d => d.SourceWarehouseId)
                    .HasConstraintName("FK_dbo.StockTransferReceiveProduct_dbo.Warehouse_SourceWarehouseId");

                entity.HasOne(d => d.StockTransferReceive)
                    .WithMany(p => p.StockTransferReceiveProduct)
                    .HasForeignKey(d => d.StockTransferReceiveId)
                    .HasConstraintName("FK_dbo.StockTransferReceiveProduct_dbo.StockTransferReceive_StockTransferReceiveId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.StockTransferReceiveProduct)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.StockTransferReceiveProduct_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<StocklessPurchase>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.EmployeeId).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.SupplierId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.StocklessPurchase)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.StockLessPurchase_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.StocklessPurchase)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.StockLessPurchase_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.StocklessPurchaseCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.StockLessPurchase_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.StocklessPurchaseDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.StockLessPurchase_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.StocklessPurchase)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_dbo.StocklessPurchase_dbo.Employee_EmployeeId");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.StocklessPurchaseModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.StockLessPurchase_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.StocklessPurchase)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_dbo.StocklessPurchase_dbo.Supplier_SupplierId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.StocklessPurchase)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.StockLessPurchase_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<StocklessPurchaseReturn>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.EmployeeId).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.SupplierId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.StocklessPurchaseReturn)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.StockLessPurchaseReturn_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.StocklessPurchaseReturn)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.StockLessPurchaseReturn_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.StocklessPurchaseReturnCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.StockLessPurchaseReturn_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.StocklessPurchaseReturnDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.StockLessPurchaseReturn_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.StocklessPurchaseReturn)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_dbo.StocklessPurchaseReturn_dbo.Employee_EmployeeId");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.StocklessPurchaseReturnModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.StockLessPurchaseReturn_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.StocklessPurchaseReturn)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_dbo.StocklessPurchaseReturn_dbo.Supplier_SupplierId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.StocklessPurchaseReturn)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.StockLessPurchaseReturn_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<StocklessSaleReturn>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_CustomerId");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.CustomerId).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.EmployeeId).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.StocklessSaleReturn)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.StockLessSaleReturn_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.StocklessSaleReturn)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.StockLessSaleReturn_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.StocklessSaleReturnCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.StockLessSaleReturn_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.StocklessSaleReturn)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_dbo.StocklessSaleReturn_dbo.Customer_CustomerId");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.StocklessSaleReturnDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.StockLessSaleReturn_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.StocklessSaleReturn)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_dbo.StocklessSaleReturn_dbo.Employee_EmployeeId");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.StocklessSaleReturnModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.StockLessSaleReturn_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.StocklessSaleReturn)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.StockLessSaleReturn_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<Subcategory>(entity =>
            {
                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CategoryId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Subcategory)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.Subcategory_dbo.Category_CategoryId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Subcategory)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.Subcategory_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SubcategoryCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.Subcategory_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.SubcategoryDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.Subcategory_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SubcategoryModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.Subcategory_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Subcategory)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.Subcategory_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<Subscription>(entity =>
            {
                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.EditionId)
                    .HasName("IX_EditionId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.EditionId).HasMaxLength(128);

                entity.Property(e => e.ExpireOn).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.RenewedOn).HasColumnType("datetime");

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Subscription)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.Subscription_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SubscriptionCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.Subscription_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.SubscriptionDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.Subscription_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.Edition)
                    .WithMany(p => p.Subscription)
                    .HasForeignKey(d => d.EditionId)
                    .HasConstraintName("FK_dbo.Subscription_dbo.Edition_EditionId");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SubscriptionModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.Subscription_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Subscription)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.Subscription_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<SubscriptionPayment>(entity =>
            {
                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.SubscriptionId)
                    .HasName("IX_SubscriptionId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.SubscriptionId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SubscriptionPayment)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.SubscriptionPayment_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SubscriptionPaymentCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.SubscriptionPayment_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.SubscriptionPaymentDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.SubscriptionPayment_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SubscriptionPaymentModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.SubscriptionPayment_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Subscription)
                    .WithMany(p => p.SubscriptionPayment)
                    .HasForeignKey(d => d.SubscriptionId)
                    .HasConstraintName("FK_dbo.Payment_dbo.Subscription_SubscriptionId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.SubscriptionPayment)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.SubscriptionPayment_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.Phone).IsRequired();

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Supplier)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.Supplier_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Supplier)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.Supplier_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SupplierCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.Supplier_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.SupplierDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.Supplier_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SupplierModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.Supplier_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Supplier)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.Supplier_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<SupplierCategory>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CategoryId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductId");

                entity.HasIndex(e => e.SubcategoryId)
                    .HasName("IX_SubcategoryId");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.ProductId).HasMaxLength(128);

                entity.Property(e => e.SubcategoryId).HasMaxLength(128);

                entity.Property(e => e.SupplierId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.SupplierCategory)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.SupplierCategory_dbo.Branch_BranchId");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SupplierCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.SupplierCategory_dbo.Category_CategoryId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SupplierCategory)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.SupplierCategory_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SupplierCategoryCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.SupplierCategory_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.SupplierCategoryDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.SupplierCategory_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SupplierCategoryModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.SupplierCategory_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SupplierCategory)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.SupplierCategory_dbo.Product_ProductId");

                entity.HasOne(d => d.Subcategory)
                    .WithMany(p => p.SupplierCategory)
                    .HasForeignKey(d => d.SubcategoryId)
                    .HasConstraintName("FK_dbo.SupplierCategory_dbo.Subcategory_SubcategoryId");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.SupplierCategory)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_dbo.SupplierCategory_dbo.Supplier_SupplierId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.SupplierCategory)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.SupplierCategory_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<Tenant>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.EditionId)
                    .HasName("IX_EditionId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.EditionId).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.SubscriptionEndTime).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.TenantCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.Tenant_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.TenantDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.Tenant_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.Edition)
                    .WithMany(p => p.Tenant)
                    .HasForeignKey(d => d.EditionId)
                    .HasConstraintName("FK_dbo.Tenant_dbo.Edition_EditionId");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.TenantModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.Tenant_dbo.AspNetUsers_ModifiedBy");
            });

            modelBuilder.Entity<TimeLog>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.HasIndex(e => e.TimeSheetId)
                    .HasName("IX_TimeSheetId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.EmployeeId).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.Property(e => e.TimeSheetId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TimeLog)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.TimeLog_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TimeLog)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.TimeLog_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.TimeLogCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.TimeLog_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.TimeLogDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.TimeLog_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TimeLog)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_dbo.TimeLog_dbo.Employee_EmployeeId");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.TimeLogModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.TimeLog_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.TimeLog)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.TimeLog_dbo.Tenant_TenantId");

                entity.HasOne(d => d.TimeSheet)
                    .WithMany(p => p.TimeLog)
                    .HasForeignKey(d => d.TimeSheetId)
                    .HasConstraintName("FK_dbo.TimeLog_dbo.TimeSheet_TimeSheetId");
            });

            modelBuilder.Entity<TimeSheet>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CheckIn).HasColumnType("datetime");

                entity.Property(e => e.CheckOut).HasColumnType("datetime");

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.EmployeeId).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TimeSheet)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.TimeSheet_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TimeSheet)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.TimeSheet_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.TimeSheetCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.TimeSheet_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.TimeSheetDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.TimeSheet_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TimeSheet)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_dbo.TimeSheet_dbo.Employee_EmployeeId");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.TimeSheetModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.TimeSheet_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.TimeSheet)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.TimeSheet_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<TransferCarrier>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TransferCarrier)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.TransferCarrier_dbo.Branch_BranchId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TransferCarrier)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.TransferCarrier_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.TransferCarrierCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.TransferCarrier_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.TransferCarrierDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.TransferCarrier_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.TransferCarrierModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.TransferCarrier_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.TransferCarrier)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.TransferCarrier_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Warehouse)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.Warehouse_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.WarehouseCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.Warehouse_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.WarehouseDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.Warehouse_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.WarehouseModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.Warehouse_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.Warehouse)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.Warehouse_dbo.Tenant_TenantId");
            });

            modelBuilder.Entity<WastageStock>(entity =>
            {
                entity.HasIndex(e => e.BranchId)
                    .HasName("IX_BranchId");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CategoryId");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_CompanyId");

                entity.HasIndex(e => e.CreatedBy)
                    .HasName("IX_CreatedBy");

                entity.HasIndex(e => e.DeletedBy)
                    .HasName("IX_DeletedBy");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ModifiedBy)
                    .HasName("IX_ModifiedBy");

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductId");

                entity.HasIndex(e => e.SubcategoryId)
                    .HasName("IX_SubcategoryId");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.HasIndex(e => e.TenantId)
                    .HasName("IX_TenantId");

                entity.HasIndex(e => e.WarehouseId)
                    .HasName("IX_WarehouseId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BranchId).HasMaxLength(128);

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.CompanyId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Deleted).HasColumnType("datetime");

                entity.Property(e => e.DeletedBy).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(128);

                entity.Property(e => e.ProductId).HasMaxLength(128);

                entity.Property(e => e.SubcategoryId).HasMaxLength(128);

                entity.Property(e => e.SupplierId).HasMaxLength(128);

                entity.Property(e => e.TenantId).HasMaxLength(128);

                entity.Property(e => e.WarehouseId).HasMaxLength(128);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.WastageStock)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_dbo.WastageStock_dbo.Branch_BranchId");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.WastageStock)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.WestageStock_dbo.Category_CategoryId");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.WastageStock)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_dbo.WastageStock_dbo.Company_CompanyId");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.WastageStockCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_dbo.WastageStock_dbo.AspNetUsers_CreatedBy");

                entity.HasOne(d => d.DeletedByNavigation)
                    .WithMany(p => p.WastageStockDeletedByNavigation)
                    .HasForeignKey(d => d.DeletedBy)
                    .HasConstraintName("FK_dbo.WastageStock_dbo.AspNetUsers_DeletedBy");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.WastageStockModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_dbo.WastageStock_dbo.AspNetUsers_ModifiedBy");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.WastageStock)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.WestageStock_dbo.Product_ProductId");

                entity.HasOne(d => d.Subcategory)
                    .WithMany(p => p.WastageStock)
                    .HasForeignKey(d => d.SubcategoryId)
                    .HasConstraintName("FK_dbo.WestageStock_dbo.Subcategory_SubcategoryId");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.WastageStock)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_dbo.WestageStock_dbo.Supplier_SupplierId");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.WastageStock)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK_dbo.WastageStock_dbo.Tenant_TenantId");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.WastageStock)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("FK_dbo.WestageStock_dbo.Warehouse_WarehouseId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
