﻿using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class Tenant
    {
        public Tenant()
        {
            Asset = new HashSet<Asset>();
            AuditLog = new HashSet<AuditLog>();
            Bank = new HashSet<Bank>();
            BankCheck = new HashSet<BankCheck>();
            Branch = new HashSet<Branch>();
            Category = new HashSet<Category>();
            Company = new HashSet<Company>();
            CompanySetting = new HashSet<CompanySetting>();
            Customer = new HashSet<Customer>();
            CustomerAddress = new HashSet<CustomerAddress>();
            DailyAccountBalance = new HashSet<DailyAccountBalance>();
            DailyBankAccountBalance = new HashSet<DailyBankAccountBalance>();
            DailyCashAccountBalance = new HashSet<DailyCashAccountBalance>();
            DailyCustomerAccountBalance = new HashSet<DailyCustomerAccountBalance>();
            DailyProductStockBalance = new HashSet<DailyProductStockBalance>();
            DailyStockBalance = new HashSet<DailyStockBalance>();
            DailySupplierAccountBalance = new HashSet<DailySupplierAccountBalance>();
            Delivery = new HashSet<Delivery>();
            DeliveryProduct = new HashSet<DeliveryProduct>();
            Deposit = new HashSet<Deposit>();
            DepositDetail = new HashSet<DepositDetail>();
            DepositHead = new HashSet<DepositHead>();
            EmailLog = new HashSet<EmailLog>();
            Employee = new HashSet<Employee>();
            Equity = new HashSet<Equity>();
            Expense = new HashSet<Expense>();
            ExpenseDetail = new HashSet<ExpenseDetail>();
            ExpenseHead = new HashSet<ExpenseHead>();
            FiscalYear = new HashSet<FiscalYear>();
            LoginAttempt = new HashSet<LoginAttempt>();
            MonthlyEmailBalance = new HashSet<MonthlyEmailBalance>();
            OpeningStock = new HashSet<OpeningStock>();
            Partner = new HashSet<Partner>();
            Product = new HashSet<Product>();
            ProductPrice = new HashSet<ProductPrice>();
            PurchaseCommissionSetup = new HashSet<PurchaseCommissionSetup>();
            PurchaseOrder = new HashSet<PurchaseOrder>();
            PurchaseOrderPayment = new HashSet<PurchaseOrderPayment>();
            PurchaseOrderProduct = new HashSet<PurchaseOrderProduct>();
            PurchaseReceive = new HashSet<PurchaseReceive>();
            PurchaseReceiveProduct = new HashSet<PurchaseReceiveProduct>();
            PurchaseReturn = new HashSet<PurchaseReturn>();
            PurchaseReturnProduct = new HashSet<PurchaseReturnProduct>();
            Sale = new HashSet<Sale>();
            SaleCommissionSetup = new HashSet<SaleCommissionSetup>();
            SalePayment = new HashSet<SalePayment>();
            SaleProduct = new HashSet<SaleProduct>();
            SaleReturn = new HashSet<SaleReturn>();
            SaleReturnProduct = new HashSet<SaleReturnProduct>();
            Scheduler = new HashSet<Scheduler>();
            Stock = new HashSet<Stock>();
            StockLessPurchaseReturnProduct = new HashSet<StockLessPurchaseReturnProduct>();
            StockLessSaleReturnProduct = new HashSet<StockLessSaleReturnProduct>();
            StockTransfer = new HashSet<StockTransfer>();
            StockTransferOrder = new HashSet<StockTransferOrder>();
            StockTransferOrderProduct = new HashSet<StockTransferOrderProduct>();
            StockTransferReceive = new HashSet<StockTransferReceive>();
            StockTransferReceiveProduct = new HashSet<StockTransferReceiveProduct>();
            StocklessPurchase = new HashSet<StocklessPurchase>();
            StocklessPurchaseReturn = new HashSet<StocklessPurchaseReturn>();
            StocklessSaleReturn = new HashSet<StocklessSaleReturn>();
            Subcategory = new HashSet<Subcategory>();
            Subscription = new HashSet<Subscription>();
            SubscriptionPayment = new HashSet<SubscriptionPayment>();
            Supplier = new HashSet<Supplier>();
            SupplierCategory = new HashSet<SupplierCategory>();
            TimeLog = new HashSet<TimeLog>();
            TimeSheet = new HashSet<TimeSheet>();
            TransferCarrier = new HashSet<TransferCarrier>();
            Warehouse = new HashSet<Warehouse>();
            WastageStock = new HashSet<WastageStock>();
        }

        public string Id { get; set; }
        public string EditionId { get; set; }
        public bool IsActive { get; set; }
        public string ConnectionString { get; set; }
        public string Name { get; set; }
        public string TenancyName { get; set; }
        public string Url { get; set; }
        public string LogoId { get; set; }
        public string LogoFilePath { get; set; }
        public bool IsInTrialPeriod { get; set; }
        public DateTime? SubscriptionEndTime { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? Deleted { get; set; }
        public string DeletedBy { get; set; }
        public string DeviceInfo { get; set; }
        public string IpAddress { get; set; }
        public string DisplayName { get; set; }
        public int NoOfShowroom { get; set; }
        public string SubscriptionId { get; set; }
        public int Package { get; set; }
        public int BonusUserAccessCount { get; set; }
        public int SpecialMonthlyDiscountPercentage { get; set; }
        public int SpecialQuarterDiscountPercentage { get; set; }
        public int SpecialHalfYearlyDiscountPercentage { get; set; }
        public int SpecialAnnualDiscountPercentage { get; set; }
        public int? BusinessType { get; set; }
        public int? Order { get; set; }
        public bool IsDemo { get; set; }
        public string OriginalPk { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual Edition Edition { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual ICollection<Asset> Asset { get; set; }
        public virtual ICollection<AuditLog> AuditLog { get; set; }
        public virtual ICollection<Bank> Bank { get; set; }
        public virtual ICollection<BankCheck> BankCheck { get; set; }
        public virtual ICollection<Branch> Branch { get; set; }
        public virtual ICollection<Category> Category { get; set; }
        public virtual ICollection<Company> Company { get; set; }
        public virtual ICollection<CompanySetting> CompanySetting { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddress { get; set; }
        public virtual ICollection<DailyAccountBalance> DailyAccountBalance { get; set; }
        public virtual ICollection<DailyBankAccountBalance> DailyBankAccountBalance { get; set; }
        public virtual ICollection<DailyCashAccountBalance> DailyCashAccountBalance { get; set; }
        public virtual ICollection<DailyCustomerAccountBalance> DailyCustomerAccountBalance { get; set; }
        public virtual ICollection<DailyProductStockBalance> DailyProductStockBalance { get; set; }
        public virtual ICollection<DailyStockBalance> DailyStockBalance { get; set; }
        public virtual ICollection<DailySupplierAccountBalance> DailySupplierAccountBalance { get; set; }
        public virtual ICollection<Delivery> Delivery { get; set; }
        public virtual ICollection<DeliveryProduct> DeliveryProduct { get; set; }
        public virtual ICollection<Deposit> Deposit { get; set; }
        public virtual ICollection<DepositDetail> DepositDetail { get; set; }
        public virtual ICollection<DepositHead> DepositHead { get; set; }
        public virtual ICollection<EmailLog> EmailLog { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<Equity> Equity { get; set; }
        public virtual ICollection<Expense> Expense { get; set; }
        public virtual ICollection<ExpenseDetail> ExpenseDetail { get; set; }
        public virtual ICollection<ExpenseHead> ExpenseHead { get; set; }
        public virtual ICollection<FiscalYear> FiscalYear { get; set; }
        public virtual ICollection<LoginAttempt> LoginAttempt { get; set; }
        public virtual ICollection<MonthlyEmailBalance> MonthlyEmailBalance { get; set; }
        public virtual ICollection<OpeningStock> OpeningStock { get; set; }
        public virtual ICollection<Partner> Partner { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<ProductPrice> ProductPrice { get; set; }
        public virtual ICollection<PurchaseCommissionSetup> PurchaseCommissionSetup { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrder { get; set; }
        public virtual ICollection<PurchaseOrderPayment> PurchaseOrderPayment { get; set; }
        public virtual ICollection<PurchaseOrderProduct> PurchaseOrderProduct { get; set; }
        public virtual ICollection<PurchaseReceive> PurchaseReceive { get; set; }
        public virtual ICollection<PurchaseReceiveProduct> PurchaseReceiveProduct { get; set; }
        public virtual ICollection<PurchaseReturn> PurchaseReturn { get; set; }
        public virtual ICollection<PurchaseReturnProduct> PurchaseReturnProduct { get; set; }
        public virtual ICollection<Sale> Sale { get; set; }
        public virtual ICollection<SaleCommissionSetup> SaleCommissionSetup { get; set; }
        public virtual ICollection<SalePayment> SalePayment { get; set; }
        public virtual ICollection<SaleProduct> SaleProduct { get; set; }
        public virtual ICollection<SaleReturn> SaleReturn { get; set; }
        public virtual ICollection<SaleReturnProduct> SaleReturnProduct { get; set; }
        public virtual ICollection<Scheduler> Scheduler { get; set; }
        public virtual ICollection<Stock> Stock { get; set; }
        public virtual ICollection<StockLessPurchaseReturnProduct> StockLessPurchaseReturnProduct { get; set; }
        public virtual ICollection<StockLessSaleReturnProduct> StockLessSaleReturnProduct { get; set; }
        public virtual ICollection<StockTransfer> StockTransfer { get; set; }
        public virtual ICollection<StockTransferOrder> StockTransferOrder { get; set; }
        public virtual ICollection<StockTransferOrderProduct> StockTransferOrderProduct { get; set; }
        public virtual ICollection<StockTransferReceive> StockTransferReceive { get; set; }
        public virtual ICollection<StockTransferReceiveProduct> StockTransferReceiveProduct { get; set; }
        public virtual ICollection<StocklessPurchase> StocklessPurchase { get; set; }
        public virtual ICollection<StocklessPurchaseReturn> StocklessPurchaseReturn { get; set; }
        public virtual ICollection<StocklessSaleReturn> StocklessSaleReturn { get; set; }
        public virtual ICollection<Subcategory> Subcategory { get; set; }
        public virtual ICollection<Subscription> Subscription { get; set; }
        public virtual ICollection<SubscriptionPayment> SubscriptionPayment { get; set; }
        public virtual ICollection<Supplier> Supplier { get; set; }
        public virtual ICollection<SupplierCategory> SupplierCategory { get; set; }
        public virtual ICollection<TimeLog> TimeLog { get; set; }
        public virtual ICollection<TimeSheet> TimeSheet { get; set; }
        public virtual ICollection<TransferCarrier> TransferCarrier { get; set; }
        public virtual ICollection<Warehouse> Warehouse { get; set; }
        public virtual ICollection<WastageStock> WastageStock { get; set; }
    }
}
