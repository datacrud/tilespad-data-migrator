using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StandaloneDatabase.Models
{
    public partial class TilesCornerDbContext : DbContext
    {
        public TilesCornerDbContext()
        {
        }

        public TilesCornerDbContext(DbContextOptions<TilesCornerDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AggregatedCounter> AggregatedCounter { get; set; }
        public virtual DbSet<AspNetPermission> AspNetPermission { get; set; }
        public virtual DbSet<AspNetResource> AspNetResource { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Asset> Asset { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<BankCheck> BankCheck { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<ComissionSetup> ComissionSetup { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Counter> Counter { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddress { get; set; }
        public virtual DbSet<DailyBankTransectionalBalance> DailyBankTransectionalBalance { get; set; }
        public virtual DbSet<DailyCashTransectionalBalance> DailyCashTransectionalBalance { get; set; }
        public virtual DbSet<DailyCustomerTransectionalBalance> DailyCustomerTransectionalBalance { get; set; }
        public virtual DbSet<DailySupplierTransectionalBalance> DailySupplierTransectionalBalance { get; set; }
        public virtual DbSet<DailyTransectionalBalance> DailyTransectionalBalance { get; set; }
        public virtual DbSet<DailyTransectionalProductStock> DailyTransectionalProductStock { get; set; }
        public virtual DbSet<DailyTransectionalStock> DailyTransectionalStock { get; set; }
        public virtual DbSet<Delivery> Delivery { get; set; }
        public virtual DbSet<DeliveryProduct> DeliveryProduct { get; set; }
        public virtual DbSet<Deposit> Deposit { get; set; }
        public virtual DbSet<DepositDetail> DepositDetail { get; set; }
        public virtual DbSet<DepositHead> DepositHead { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Equity> Equity { get; set; }
        public virtual DbSet<Expense> Expense { get; set; }
        public virtual DbSet<ExpenseDetail> ExpenseDetail { get; set; }
        public virtual DbSet<ExpenseHead> ExpenseHead { get; set; }
        public virtual DbSet<Hash> Hash { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<JobParameter> JobParameter { get; set; }
        public virtual DbSet<JobQueue> JobQueue { get; set; }
        public virtual DbSet<List> List { get; set; }
        public virtual DbSet<LoginAttempt> LoginAttempt { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<OpeningStock> OpeningStock { get; set; }
        public virtual DbSet<Partner> Partner { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public virtual DbSet<PurchaseOrderPayment> PurchaseOrderPayment { get; set; }
        public virtual DbSet<PurchaseOrderProduct> PurchaseOrderProduct { get; set; }
        public virtual DbSet<PurchaseReceive> PurchaseReceive { get; set; }
        public virtual DbSet<PurchaseReceiveProduct> PurchaseReceiveProduct { get; set; }
        public virtual DbSet<PurchaseReturn> PurchaseReturn { get; set; }
        public virtual DbSet<PurchaseReturnProduct> PurchaseReturnProduct { get; set; }
        public virtual DbSet<Sale> Sale { get; set; }
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
        public virtual DbSet<Subcategory> Subcategory { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<SupplierCategory> SupplierCategory { get; set; }
        public virtual DbSet<TransectionLog> TransectionLog { get; set; }
        public virtual DbSet<Warehouse> Warehouse { get; set; }
        public virtual DbSet<WestageStock> WestageStock { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\sqlexpress;Database=TilesCornerDb;Trusted_Connection=True;");
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

            modelBuilder.Entity<AspNetPermission>(entity =>
            {
                entity.HasIndex(e => e.ResourceId)
                    .HasName("IX_ResourceId");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.ResourceId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.RoleName).IsRequired();

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.AspNetPermission)
                    .HasForeignKey(d => d.ResourceId)
                    .HasConstraintName("FK_dbo.AspNetPermissions_dbo.AspNetResources_ResourceId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetPermission)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetPermissions_dbo.AspNetRoles_RoleId");
            });

            modelBuilder.Entity<AspNetResource>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Route).IsRequired();
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.UserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Asset>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.HasIndex(e => e.AccountNumber)
                    .HasName("IX_AccountNumber")
                    .IsUnique();

                entity.HasIndex(e => e.Code)
                    .HasName("IX_Code")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.AccountName).IsRequired();

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Branch).IsRequired();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<BankCheck>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CheckDate).HasColumnType("datetime");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("IX_Code")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("IX_Name")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("IX_Code")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("IX_Name")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ComissionSetup>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.SupplierId).HasMaxLength(128);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.ComissionSetup)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_dbo.ComissionSetup_dbo.Supplier_SupplierId");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.FiscalYearEndDate).HasColumnType("datetime");

                entity.Property(e => e.FiscalYearStartDate).HasColumnType("datetime");

                entity.Property(e => e.HostingValidTill).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");
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
                entity.HasIndex(e => e.Code)
                    .HasName("IX_Code")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<CustomerAddress>(entity =>
            {
                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_CustomerId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerAddress)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_dbo.CustomerAddress_dbo.Customer_CustomerId");
            });

            modelBuilder.Entity<DailyBankTransectionalBalance>(entity =>
            {
                entity.HasIndex(e => e.BankId)
                    .HasName("IX_BankId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.BankId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.DailyBankTransectionalBalance)
                    .HasForeignKey(d => d.BankId)
                    .HasConstraintName("FK_dbo.DailyBankTransectionalBalance_dbo.Bank_BankId");
            });

            modelBuilder.Entity<DailyCashTransectionalBalance>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");
            });

            modelBuilder.Entity<DailyCustomerTransectionalBalance>(entity =>
            {
                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_CustomerId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.DailyCustomerTransectionalBalance)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_dbo.DailyCustomerTransectionalBalance_dbo.Customer_CustomerId");
            });

            modelBuilder.Entity<DailySupplierTransectionalBalance>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.SupplierId).HasMaxLength(128);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.DailySupplierTransectionalBalance)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_dbo.DailySupplierTransectionalBalance_dbo.Supplier_SupplierId");
            });

            modelBuilder.Entity<DailyTransectionalBalance>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");
            });

            modelBuilder.Entity<DailyTransectionalProductStock>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");
            });

            modelBuilder.Entity<DailyTransectionalStock>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");
            });

            modelBuilder.Entity<Delivery>(entity =>
            {
                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_CustomerId");

                entity.HasIndex(e => e.DeliveryNumber)
                    .HasName("IX_DeliveryNumber")
                    .IsUnique();

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.SaleId)
                    .HasName("IX_SaleId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DeliveryNumber).HasMaxLength(20);

                entity.Property(e => e.EmployeeId).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.SaleId).HasMaxLength(128);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Delivery)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_dbo.Delivery_dbo.Customer_CustomerId");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Delivery)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_dbo.Delivery_dbo.Employee_EmployeeId");

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.Delivery)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_dbo.Delivery_dbo.Sale_SaleId");
            });

            modelBuilder.Entity<DeliveryProduct>(entity =>
            {
                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CategoryId");

                entity.HasIndex(e => e.DeliveryId)
                    .HasName("IX_DeliveryId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductId");

                entity.HasIndex(e => e.SaleId)
                    .HasName("IX_SaleId");

                entity.HasIndex(e => e.SubcategoryId)
                    .HasName("IX_SubcategoryId");

                entity.HasIndex(e => e.WarehouseId)
                    .HasName("IX_WarehouseId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DeliveryId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasMaxLength(128);

                entity.Property(e => e.SaleId).HasMaxLength(128);

                entity.Property(e => e.SubcategoryId).HasMaxLength(128);

                entity.Property(e => e.WarehouseId).HasMaxLength(128);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.DeliveryProduct)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.DeliveryProduct_dbo.Category_CategoryId");

                entity.HasOne(d => d.Delivery)
                    .WithMany(p => p.DeliveryProduct)
                    .HasForeignKey(d => d.DeliveryId)
                    .HasConstraintName("FK_dbo.DeliveryProduct_dbo.Delivery_DeliveryId");

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

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.DeliveryProduct)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("FK_dbo.DeliveryProduct_dbo.Warehouse_WarehouseId");
            });

            modelBuilder.Entity<Deposit>(entity =>
            {
                entity.HasIndex(e => e.DepositHeadId)
                    .HasName("IX_DepositHeadId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.InvoiceNumber)
                    .HasName("IX_InvoiceNumber")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DepositHeadId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.InvoiceNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.HasOne(d => d.DepositHead)
                    .WithMany(p => p.Deposit)
                    .HasForeignKey(d => d.DepositHeadId)
                    .HasConstraintName("FK_dbo.Deposit_dbo.DepositHead_DepositHeadId");
            });

            modelBuilder.Entity<DepositDetail>(entity =>
            {
                entity.HasIndex(e => e.DepositId)
                    .HasName("IX_DepositId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DepositId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.HasOne(d => d.Deposit)
                    .WithMany(p => p.DepositDetail)
                    .HasForeignKey(d => d.DepositId)
                    .HasConstraintName("FK_dbo.DepositDetail_dbo.Deposit_DepositId");
            });

            modelBuilder.Entity<DepositHead>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("IX_Code")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("IX_Name")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("IX_Code")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Equity>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");
            });

            modelBuilder.Entity<Expense>(entity =>
            {
                entity.HasIndex(e => e.ExpenseHeadId)
                    .HasName("IX_ExpenseHeadId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.InvoiceNumber)
                    .HasName("IX_InvoiceNumber")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ExpenseHeadId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.InvoiceNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.HasOne(d => d.ExpenseHead)
                    .WithMany(p => p.Expense)
                    .HasForeignKey(d => d.ExpenseHeadId)
                    .HasConstraintName("FK_dbo.Expense_dbo.ExpenseHead_ExpenseHeadId");
            });

            modelBuilder.Entity<ExpenseDetail>(entity =>
            {
                entity.HasIndex(e => e.ExpenseId)
                    .HasName("IX_ExpenseId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ExpenseId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.HasOne(d => d.Expense)
                    .WithMany(p => p.ExpenseDetail)
                    .HasForeignKey(d => d.ExpenseId)
                    .HasConstraintName("FK_dbo.ExpenseDetail_dbo.Expense_ExpenseId");
            });

            modelBuilder.Entity<ExpenseHead>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("IX_Code")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("IX_Name")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);
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
                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");
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

            modelBuilder.Entity<OpeningStock>(entity =>
            {
                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CategoryId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductId");

                entity.HasIndex(e => e.SubcategoryId)
                    .HasName("IX_SubcategoryId");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.HasIndex(e => e.WarehouseId)
                    .HasName("IX_WarehouseId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasMaxLength(128);

                entity.Property(e => e.SubcategoryId).HasMaxLength(128);

                entity.Property(e => e.SupplierId).HasMaxLength(128);

                entity.Property(e => e.WarehouseId).HasMaxLength(128);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.OpeningStock)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.OpeningStock_dbo.Category_CategoryId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OpeningStockNavigation)
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

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.OpeningStock)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("FK_dbo.OpeningStock_dbo.Warehouse_WarehouseId");
            });

            modelBuilder.Entity<Partner>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.PartnerFrom).HasColumnType("datetime");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CategoryId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.SubcategoryId)
                    .HasName("IX_SubcategoryId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.Code).IsRequired();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.SubcategoryId).HasMaxLength(128);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.Product_dbo.Category_CategoryId");

                entity.HasOne(d => d.Subcategory)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.SubcategoryId)
                    .HasConstraintName("FK_dbo.Product_dbo.Subcategory_SubcategoryId");
            });

            modelBuilder.Entity<PurchaseOrder>(entity =>
            {
                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.OrderNumber)
                    .HasName("IX_OrderNumber")
                    .IsUnique();

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.OrderNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SupplierId).HasMaxLength(128);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PurchaseOrder)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_dbo.PurchaseOrder_dbo.Employee_EmployeeId");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PurchaseOrder)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_dbo.PurchaseOrder_dbo.Supplier_SupplierId");
            });

            modelBuilder.Entity<PurchaseOrderPayment>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.PurchaseOrderId)
                    .HasName("IX_PurchaseOrderId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.PurchaseOrderId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.PurchaseOrderPayment)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .HasConstraintName("FK_dbo.PurchaseOrderPayment_dbo.PurchaseOrder_PurchaseOrderId");
            });

            modelBuilder.Entity<PurchaseOrderProduct>(entity =>
            {
                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CategoryId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductId");

                entity.HasIndex(e => e.PurchaseOrderId)
                    .HasName("IX_PurchaseOrderId");

                entity.HasIndex(e => e.SubcategoryId)
                    .HasName("IX_SubcategoryId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasMaxLength(128);

                entity.Property(e => e.PurchaseOrderId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.SubcategoryId).HasMaxLength(128);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.PurchaseOrderProduct)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.PurchaseOrderProduct_dbo.Category_CategoryId");

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
            });

            modelBuilder.Entity<PurchaseReceive>(entity =>
            {
                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.OrderedEmployeeId)
                    .HasName("IX_OrderedEmployeeId");

                entity.HasIndex(e => e.PurchaseOrderId)
                    .HasName("IX_PurchaseOrderId");

                entity.HasIndex(e => e.ReceiveNumber)
                    .HasName("IX_ReceiveNumber")
                    .IsUnique();

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.OrderedEmployeeId).HasMaxLength(128);

                entity.Property(e => e.PurchaseOrderId).HasMaxLength(128);

                entity.Property(e => e.ReceiveNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SupplierId).HasMaxLength(128);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PurchaseReceiveEmployee)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_dbo.PurchaseReceive_dbo.Employee_EmployeeId");

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
            });

            modelBuilder.Entity<PurchaseReceiveProduct>(entity =>
            {
                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CategoryId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductId");

                entity.HasIndex(e => e.PurchaseOrderId)
                    .HasName("IX_PurchaseOrderId");

                entity.HasIndex(e => e.PurchaseReceiveId)
                    .HasName("IX_PurchaseReceiveId");

                entity.HasIndex(e => e.SubcategoryId)
                    .HasName("IX_SubcategoryId");

                entity.HasIndex(e => e.WarehouseId)
                    .HasName("IX_WarehouseId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasMaxLength(128);

                entity.Property(e => e.PurchaseOrderId).HasMaxLength(128);

                entity.Property(e => e.PurchaseReceiveId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.SubcategoryId).HasMaxLength(128);

                entity.Property(e => e.WarehouseId).HasMaxLength(128);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.PurchaseReceiveProduct)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.PurchaseReceiveProduct_dbo.Category_CategoryId");

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

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.PurchaseReceiveProduct)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("FK_dbo.PurchaseReceiveProduct_dbo.Warehouse_WarehouseId");
            });

            modelBuilder.Entity<PurchaseReturn>(entity =>
            {
                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.InvoiceNumber)
                    .HasName("IX_InvoiceNumber")
                    .IsUnique();

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasMaxLength(128);

                entity.Property(e => e.InvoiceNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.SupplierId).HasMaxLength(128);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PurchaseReturn)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_dbo.PurchaseReturn_dbo.Employee_EmployeeId");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PurchaseReturn)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_dbo.PurchaseReturn_dbo.Supplier_SupplierId");
            });

            modelBuilder.Entity<PurchaseReturnProduct>(entity =>
            {
                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CategoryId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductId");

                entity.HasIndex(e => e.PurchaseReturnId)
                    .HasName("IX_PurchaseReturnId");

                entity.HasIndex(e => e.SubcategoryId)
                    .HasName("IX_SubcategoryId");

                entity.HasIndex(e => e.WarehouseId)
                    .HasName("IX_WarehouseId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasMaxLength(128);

                entity.Property(e => e.PurchaseReturnId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.SubcategoryId).HasMaxLength(128);

                entity.Property(e => e.WarehouseId).HasMaxLength(128);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.PurchaseReturnProduct)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.PurchaseReturnProduct_dbo.Category_CategoryId");

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

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.PurchaseReturnProduct)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("FK_dbo.PurchaseReturnProduct_dbo.Warehouse_WarehouseId");
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_CustomerId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.OrderNumber)
                    .HasName("IX_OrderNumber")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.OrderNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Sale)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_dbo.Sale_dbo.Customer_CustomerId");
            });

            modelBuilder.Entity<SalePayment>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.SaleId)
                    .HasName("IX_SaleId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.SaleId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SalePayment)
                    .HasForeignKey(d => d.SaleId)
                    .HasConstraintName("FK_dbo.SalePayment_dbo.Sale_SaleId");
            });

            modelBuilder.Entity<SaleProduct>(entity =>
            {
                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CategoryId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductId");

                entity.HasIndex(e => e.SaleId)
                    .HasName("IX_SaleId");

                entity.HasIndex(e => e.SubcategoryId)
                    .HasName("IX_SubcategoryId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasMaxLength(128);

                entity.Property(e => e.SaleId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.SubcategoryId).HasMaxLength(128);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SaleProduct)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.SaleProduct_dbo.Category_CategoryId");

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
            });

            modelBuilder.Entity<SaleReturn>(entity =>
            {
                entity.HasIndex(e => e.CustomerId)
                    .HasName("IX_CustomerId");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("IX_EmployeeId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.InvoiceNumber)
                    .HasName("IX_InvoiceNumber")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CustomerId).HasMaxLength(128);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasMaxLength(128);

                entity.Property(e => e.InvoiceNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SaleReturn)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_dbo.SaleReturn_dbo.Customer_CustomerId");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.SaleReturn)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_dbo.SaleReturn_dbo.Employee_EmployeeId");
            });

            modelBuilder.Entity<SaleReturnProduct>(entity =>
            {
                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CategoryId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductId");

                entity.HasIndex(e => e.SaleReturnId)
                    .HasName("IX_SaleReturnId");

                entity.HasIndex(e => e.SubcategoryId)
                    .HasName("IX_SubcategoryId");

                entity.HasIndex(e => e.WarehouseId)
                    .HasName("IX_WarehouseId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasMaxLength(128);

                entity.Property(e => e.SaleReturnId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.SubcategoryId).HasMaxLength(128);

                entity.Property(e => e.WarehouseId).HasMaxLength(128);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SaleReturnProduct)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.SaleReturnProduct_dbo.Category_CategoryId");

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

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.SaleReturnProduct)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("FK_dbo.SaleReturnProduct_dbo.Warehouse_WarehouseId");
            });

            modelBuilder.Entity<Scheduler>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LastRunTime).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.NextRunTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
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
                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CategoryId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductId");

                entity.HasIndex(e => e.SubcategoryId)
                    .HasName("IX_SubcategoryId");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.HasIndex(e => e.WarehouseId)
                    .HasName("IX_WarehouseId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasMaxLength(128);

                entity.Property(e => e.SubcategoryId).HasMaxLength(128);

                entity.Property(e => e.SupplierId).HasMaxLength(128);

                entity.Property(e => e.WarehouseId).HasMaxLength(128);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Stock)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.Stock_dbo.Category_CategoryId");

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

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.Stock)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("FK_dbo.Stock_dbo.Warehouse_WarehouseId");
            });

            modelBuilder.Entity<StockTransfer>(entity =>
            {
                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CategoryId");

                entity.HasIndex(e => e.DestinationWarehouseId)
                    .HasName("IX_DestinationWarehouseId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductId");

                entity.HasIndex(e => e.SourceWarehouseId)
                    .HasName("IX_SourceWarehouseId");

                entity.HasIndex(e => e.SubcategoryId)
                    .HasName("IX_SubcategoryId");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.DestinationWarehouseId).HasMaxLength(128);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasMaxLength(128);

                entity.Property(e => e.SourceWarehouseId).HasMaxLength(128);

                entity.Property(e => e.SubcategoryId).HasMaxLength(128);

                entity.Property(e => e.SupplierId).HasMaxLength(128);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.StockTransfer)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.StockTransfer_dbo.Category_CategoryId");

                entity.HasOne(d => d.DestinationWarehouse)
                    .WithMany(p => p.StockTransferDestinationWarehouse)
                    .HasForeignKey(d => d.DestinationWarehouseId)
                    .HasConstraintName("FK_dbo.StockTransfer_dbo.Warehouse_DestinationWarehouseId");

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
            });

            modelBuilder.Entity<Subcategory>(entity =>
            {
                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CategoryId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Subcategory)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.Subcategory_dbo.Category_CategoryId");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("IX_Code")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Phone).IsRequired();
            });

            modelBuilder.Entity<SupplierCategory>(entity =>
            {
                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CategoryId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductId");

                entity.HasIndex(e => e.SubcategoryId)
                    .HasName("IX_SubcategoryId");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasMaxLength(128);

                entity.Property(e => e.SubcategoryId).HasMaxLength(128);

                entity.Property(e => e.SupplierId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.SupplierCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.SupplierCategory_dbo.Category_CategoryId");

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
            });

            modelBuilder.Entity<TransectionLog>(entity =>
            {
                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("IX_Code")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.Name)
                    .HasName("IX_Name")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<WestageStock>(entity =>
            {
                entity.HasIndex(e => e.CategoryId)
                    .HasName("IX_CategoryId");

                entity.HasIndex(e => e.Id)
                    .HasName("IX_Id")
                    .IsUnique();

                entity.HasIndex(e => e.ProductId)
                    .HasName("IX_ProductId");

                entity.HasIndex(e => e.SubcategoryId)
                    .HasName("IX_SubcategoryId");

                entity.HasIndex(e => e.SupplierId)
                    .HasName("IX_SupplierId");

                entity.HasIndex(e => e.WarehouseId)
                    .HasName("IX_WarehouseId");

                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.CategoryId).HasMaxLength(128);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasMaxLength(128);

                entity.Property(e => e.SubcategoryId).HasMaxLength(128);

                entity.Property(e => e.SupplierId).HasMaxLength(128);

                entity.Property(e => e.WarehouseId).HasMaxLength(128);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.WestageStock)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.WestageStock_dbo.Category_CategoryId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.WestageStock)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_dbo.WestageStock_dbo.Product_ProductId");

                entity.HasOne(d => d.Subcategory)
                    .WithMany(p => p.WestageStock)
                    .HasForeignKey(d => d.SubcategoryId)
                    .HasConstraintName("FK_dbo.WestageStock_dbo.Subcategory_SubcategoryId");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.WestageStock)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_dbo.WestageStock_dbo.Supplier_SupplierId");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.WestageStock)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("FK_dbo.WestageStock_dbo.Warehouse_WarehouseId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
