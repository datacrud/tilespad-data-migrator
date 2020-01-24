using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class AspNetUsers
    {
        public AspNetUsers()
        {
            AppPermissionsCreatedByNavigation = new HashSet<AppPermissions>();
            AppPermissionsDeletedByNavigation = new HashSet<AppPermissions>();
            AppPermissionsModifiedByNavigation = new HashSet<AppPermissions>();
            AppResourcesCreatedByNavigation = new HashSet<AppResources>();
            AppResourcesDeletedByNavigation = new HashSet<AppResources>();
            AppResourcesModifiedByNavigation = new HashSet<AppResources>();
            AppRolesCreatedByNavigation = new HashSet<AppRoles>();
            AppRolesDeletedByNavigation = new HashSet<AppRoles>();
            AppRolesModifiedByNavigation = new HashSet<AppRoles>();
            AspNetUserClaimsCreatedByNavigation = new HashSet<AspNetUserClaims>();
            AspNetUserClaimsDeletedByNavigation = new HashSet<AspNetUserClaims>();
            AspNetUserClaimsModifiedByNavigation = new HashSet<AspNetUserClaims>();
            AspNetUserClaimsUser = new HashSet<AspNetUserClaims>();
            AspNetUserLoginsCreatedByNavigation = new HashSet<AspNetUserLogins>();
            AspNetUserLoginsDeletedByNavigation = new HashSet<AspNetUserLogins>();
            AspNetUserLoginsModifiedByNavigation = new HashSet<AspNetUserLogins>();
            AspNetUserLoginsUser = new HashSet<AspNetUserLogins>();
            AspNetUserRolesDeletedByNavigation = new HashSet<AspNetUserRoles>();
            AspNetUserRolesModifiedByNavigation = new HashSet<AspNetUserRoles>();
            AspNetUserRolesUser = new HashSet<AspNetUserRoles>();
            AssetCreatedByNavigation = new HashSet<Asset>();
            AssetDeletedByNavigation = new HashSet<Asset>();
            AssetModifiedByNavigation = new HashSet<Asset>();
            AuditLogCreatedByNavigation = new HashSet<AuditLog>();
            AuditLogDeletedByNavigation = new HashSet<AuditLog>();
            AuditLogModifiedByNavigation = new HashSet<AuditLog>();
            BankCheckCreatedByNavigation = new HashSet<BankCheck>();
            BankCheckDeletedByNavigation = new HashSet<BankCheck>();
            BankCheckModifiedByNavigation = new HashSet<BankCheck>();
            BankCreatedByNavigation = new HashSet<Bank>();
            BankDeletedByNavigation = new HashSet<Bank>();
            BankModifiedByNavigation = new HashSet<Bank>();
            BranchCreatedByNavigation = new HashSet<Branch>();
            BranchDeletedByNavigation = new HashSet<Branch>();
            BranchModifiedByNavigation = new HashSet<Branch>();
            CategoryCreatedByNavigation = new HashSet<Category>();
            CategoryDeletedByNavigation = new HashSet<Category>();
            CategoryModifiedByNavigation = new HashSet<Category>();
            CompanyCreatedByNavigation = new HashSet<Company>();
            CompanyDeletedByNavigation = new HashSet<Company>();
            CompanyModifiedByNavigation = new HashSet<Company>();
            CompanySettingCreatedByNavigation = new HashSet<CompanySetting>();
            CompanySettingDeletedByNavigation = new HashSet<CompanySetting>();
            CompanySettingModifiedByNavigation = new HashSet<CompanySetting>();
            CustomerAddressCreatedByNavigation = new HashSet<CustomerAddress>();
            CustomerAddressDeletedByNavigation = new HashSet<CustomerAddress>();
            CustomerAddressModifiedByNavigation = new HashSet<CustomerAddress>();
            CustomerCreatedByNavigation = new HashSet<Customer>();
            CustomerDeletedByNavigation = new HashSet<Customer>();
            CustomerModifiedByNavigation = new HashSet<Customer>();
            DailyAccountBalanceCreatedByNavigation = new HashSet<DailyAccountBalance>();
            DailyAccountBalanceDeletedByNavigation = new HashSet<DailyAccountBalance>();
            DailyAccountBalanceModifiedByNavigation = new HashSet<DailyAccountBalance>();
            DailyBankAccountBalanceCreatedByNavigation = new HashSet<DailyBankAccountBalance>();
            DailyBankAccountBalanceDeletedByNavigation = new HashSet<DailyBankAccountBalance>();
            DailyBankAccountBalanceModifiedByNavigation = new HashSet<DailyBankAccountBalance>();
            DailyCashAccountBalanceCreatedByNavigation = new HashSet<DailyCashAccountBalance>();
            DailyCashAccountBalanceDeletedByNavigation = new HashSet<DailyCashAccountBalance>();
            DailyCashAccountBalanceModifiedByNavigation = new HashSet<DailyCashAccountBalance>();
            DailyCustomerAccountBalanceCreatedByNavigation = new HashSet<DailyCustomerAccountBalance>();
            DailyCustomerAccountBalanceDeletedByNavigation = new HashSet<DailyCustomerAccountBalance>();
            DailyCustomerAccountBalanceModifiedByNavigation = new HashSet<DailyCustomerAccountBalance>();
            DailyProductStockBalanceCreatedByNavigation = new HashSet<DailyProductStockBalance>();
            DailyProductStockBalanceDeletedByNavigation = new HashSet<DailyProductStockBalance>();
            DailyProductStockBalanceModifiedByNavigation = new HashSet<DailyProductStockBalance>();
            DailyStockBalanceCreatedByNavigation = new HashSet<DailyStockBalance>();
            DailyStockBalanceDeletedByNavigation = new HashSet<DailyStockBalance>();
            DailyStockBalanceModifiedByNavigation = new HashSet<DailyStockBalance>();
            DailySupplierAccountBalanceCreatedByNavigation = new HashSet<DailySupplierAccountBalance>();
            DailySupplierAccountBalanceDeletedByNavigation = new HashSet<DailySupplierAccountBalance>();
            DailySupplierAccountBalanceModifiedByNavigation = new HashSet<DailySupplierAccountBalance>();
            DeliveryCreatedByNavigation = new HashSet<Delivery>();
            DeliveryDeletedByNavigation = new HashSet<Delivery>();
            DeliveryModifiedByNavigation = new HashSet<Delivery>();
            DeliveryProductCreatedByNavigation = new HashSet<DeliveryProduct>();
            DeliveryProductDeletedByNavigation = new HashSet<DeliveryProduct>();
            DeliveryProductModifiedByNavigation = new HashSet<DeliveryProduct>();
            DepositCreatedByNavigation = new HashSet<Deposit>();
            DepositDeletedByNavigation = new HashSet<Deposit>();
            DepositDetailCreatedByNavigation = new HashSet<DepositDetail>();
            DepositDetailDeletedByNavigation = new HashSet<DepositDetail>();
            DepositDetailModifiedByNavigation = new HashSet<DepositDetail>();
            DepositHeadCreatedByNavigation = new HashSet<DepositHead>();
            DepositHeadDeletedByNavigation = new HashSet<DepositHead>();
            DepositHeadModifiedByNavigation = new HashSet<DepositHead>();
            DepositModifiedByNavigation = new HashSet<Deposit>();
            EditionCreatedByNavigation = new HashSet<Edition>();
            EditionDeletedByNavigation = new HashSet<Edition>();
            EditionModifiedByNavigation = new HashSet<Edition>();
            EmailLogCreatedByNavigation = new HashSet<EmailLog>();
            EmailLogDeletedByNavigation = new HashSet<EmailLog>();
            EmailLogModifiedByNavigation = new HashSet<EmailLog>();
            EmployeeCreatedByNavigation = new HashSet<Employee>();
            EmployeeDeletedByNavigation = new HashSet<Employee>();
            EmployeeModifiedByNavigation = new HashSet<Employee>();
            EquityCreatedByNavigation = new HashSet<Equity>();
            EquityDeletedByNavigation = new HashSet<Equity>();
            EquityModifiedByNavigation = new HashSet<Equity>();
            ExpenseCreatedByNavigation = new HashSet<Expense>();
            ExpenseDeletedByNavigation = new HashSet<Expense>();
            ExpenseDetailCreatedByNavigation = new HashSet<ExpenseDetail>();
            ExpenseDetailDeletedByNavigation = new HashSet<ExpenseDetail>();
            ExpenseDetailModifiedByNavigation = new HashSet<ExpenseDetail>();
            ExpenseHeadCreatedByNavigation = new HashSet<ExpenseHead>();
            ExpenseHeadDeletedByNavigation = new HashSet<ExpenseHead>();
            ExpenseHeadModifiedByNavigation = new HashSet<ExpenseHead>();
            ExpenseModifiedByNavigation = new HashSet<Expense>();
            FeatureCreatedByNavigation = new HashSet<Feature>();
            FeatureDeletedByNavigation = new HashSet<Feature>();
            FeatureModifiedByNavigation = new HashSet<Feature>();
            FiscalYearCreatedByNavigation = new HashSet<FiscalYear>();
            FiscalYearDeletedByNavigation = new HashSet<FiscalYear>();
            FiscalYearModifiedByNavigation = new HashSet<FiscalYear>();
            InverseCreatedByNavigation = new HashSet<AspNetUsers>();
            InverseDeletedByNavigation = new HashSet<AspNetUsers>();
            InverseModifiedByNavigation = new HashSet<AspNetUsers>();
            LoginAttemptCreatedByNavigation = new HashSet<LoginAttempt>();
            LoginAttemptDeletedByNavigation = new HashSet<LoginAttempt>();
            LoginAttemptModifiedByNavigation = new HashSet<LoginAttempt>();
            MonthlyEmailBalanceCreatedByNavigation = new HashSet<MonthlyEmailBalance>();
            MonthlyEmailBalanceDeletedByNavigation = new HashSet<MonthlyEmailBalance>();
            MonthlyEmailBalanceModifiedByNavigation = new HashSet<MonthlyEmailBalance>();
            OpeningStockCreatedByNavigation = new HashSet<OpeningStock>();
            OpeningStockDeletedByNavigation = new HashSet<OpeningStock>();
            OpeningStockModifiedByNavigation = new HashSet<OpeningStock>();
            PartnerCreatedByNavigation = new HashSet<Partner>();
            PartnerDeletedByNavigation = new HashSet<Partner>();
            PartnerModifiedByNavigation = new HashSet<Partner>();
            ProductCreatedByNavigation = new HashSet<Product>();
            ProductDeletedByNavigation = new HashSet<Product>();
            ProductModifiedByNavigation = new HashSet<Product>();
            ProductPriceCreatedByNavigation = new HashSet<ProductPrice>();
            ProductPriceDeletedByNavigation = new HashSet<ProductPrice>();
            ProductPriceModifiedByNavigation = new HashSet<ProductPrice>();
            PurchaseCommissionSetupCreatedByNavigation = new HashSet<PurchaseCommissionSetup>();
            PurchaseCommissionSetupDeletedByNavigation = new HashSet<PurchaseCommissionSetup>();
            PurchaseCommissionSetupModifiedByNavigation = new HashSet<PurchaseCommissionSetup>();
            PurchaseOrderCreatedByNavigation = new HashSet<PurchaseOrder>();
            PurchaseOrderDeletedByNavigation = new HashSet<PurchaseOrder>();
            PurchaseOrderModifiedByNavigation = new HashSet<PurchaseOrder>();
            PurchaseOrderPaymentCreatedByNavigation = new HashSet<PurchaseOrderPayment>();
            PurchaseOrderPaymentDeletedByNavigation = new HashSet<PurchaseOrderPayment>();
            PurchaseOrderPaymentModifiedByNavigation = new HashSet<PurchaseOrderPayment>();
            PurchaseOrderProductCreatedByNavigation = new HashSet<PurchaseOrderProduct>();
            PurchaseOrderProductDeletedByNavigation = new HashSet<PurchaseOrderProduct>();
            PurchaseOrderProductModifiedByNavigation = new HashSet<PurchaseOrderProduct>();
            PurchaseReceiveCreatedByNavigation = new HashSet<PurchaseReceive>();
            PurchaseReceiveDeletedByNavigation = new HashSet<PurchaseReceive>();
            PurchaseReceiveModifiedByNavigation = new HashSet<PurchaseReceive>();
            PurchaseReceiveProductCreatedByNavigation = new HashSet<PurchaseReceiveProduct>();
            PurchaseReceiveProductDeletedByNavigation = new HashSet<PurchaseReceiveProduct>();
            PurchaseReceiveProductModifiedByNavigation = new HashSet<PurchaseReceiveProduct>();
            PurchaseReturnCreatedByNavigation = new HashSet<PurchaseReturn>();
            PurchaseReturnDeletedByNavigation = new HashSet<PurchaseReturn>();
            PurchaseReturnModifiedByNavigation = new HashSet<PurchaseReturn>();
            PurchaseReturnProductCreatedByNavigation = new HashSet<PurchaseReturnProduct>();
            PurchaseReturnProductDeletedByNavigation = new HashSet<PurchaseReturnProduct>();
            PurchaseReturnProductModifiedByNavigation = new HashSet<PurchaseReturnProduct>();
            RfqCreatedByNavigation = new HashSet<Rfq>();
            RfqDeletedByNavigation = new HashSet<Rfq>();
            RfqModifiedByNavigation = new HashSet<Rfq>();
            SaleCommissionSetupCreatedByNavigation = new HashSet<SaleCommissionSetup>();
            SaleCommissionSetupDeletedByNavigation = new HashSet<SaleCommissionSetup>();
            SaleCommissionSetupModifiedByNavigation = new HashSet<SaleCommissionSetup>();
            SaleCreatedByNavigation = new HashSet<Sale>();
            SaleDeletedByNavigation = new HashSet<Sale>();
            SaleModifiedByNavigation = new HashSet<Sale>();
            SalePaymentCreatedByNavigation = new HashSet<SalePayment>();
            SalePaymentDeletedByNavigation = new HashSet<SalePayment>();
            SalePaymentModifiedByNavigation = new HashSet<SalePayment>();
            SaleProductCreatedByNavigation = new HashSet<SaleProduct>();
            SaleProductDeletedByNavigation = new HashSet<SaleProduct>();
            SaleProductModifiedByNavigation = new HashSet<SaleProduct>();
            SaleReturnCreatedByNavigation = new HashSet<SaleReturn>();
            SaleReturnDeletedByNavigation = new HashSet<SaleReturn>();
            SaleReturnModifiedByNavigation = new HashSet<SaleReturn>();
            SaleReturnProductCreatedByNavigation = new HashSet<SaleReturnProduct>();
            SaleReturnProductDeletedByNavigation = new HashSet<SaleReturnProduct>();
            SaleReturnProductModifiedByNavigation = new HashSet<SaleReturnProduct>();
            SchedulerCreatedByNavigation = new HashSet<Scheduler>();
            SchedulerDeletedByNavigation = new HashSet<Scheduler>();
            SchedulerModifiedByNavigation = new HashSet<Scheduler>();
            StockCreatedByNavigation = new HashSet<Stock>();
            StockDeletedByNavigation = new HashSet<Stock>();
            StockModifiedByNavigation = new HashSet<Stock>();
            StockTransferCreatedByNavigation = new HashSet<StockTransfer>();
            StockTransferDeletedByNavigation = new HashSet<StockTransfer>();
            StockTransferModifiedByNavigation = new HashSet<StockTransfer>();
            StockTransferOrderCreatedByNavigation = new HashSet<StockTransferOrder>();
            StockTransferOrderDeletedByNavigation = new HashSet<StockTransferOrder>();
            StockTransferOrderModifiedByNavigation = new HashSet<StockTransferOrder>();
            StockTransferOrderProductCreatedByNavigation = new HashSet<StockTransferOrderProduct>();
            StockTransferOrderProductDeletedByNavigation = new HashSet<StockTransferOrderProduct>();
            StockTransferOrderProductModifiedByNavigation = new HashSet<StockTransferOrderProduct>();
            StockTransferReceiveCreatedByNavigation = new HashSet<StockTransferReceive>();
            StockTransferReceiveDeletedByNavigation = new HashSet<StockTransferReceive>();
            StockTransferReceiveModifiedByNavigation = new HashSet<StockTransferReceive>();
            StockTransferReceiveProductCreatedByNavigation = new HashSet<StockTransferReceiveProduct>();
            StockTransferReceiveProductDeletedByNavigation = new HashSet<StockTransferReceiveProduct>();
            StockTransferReceiveProductModifiedByNavigation = new HashSet<StockTransferReceiveProduct>();
            StocklessPurchaseCreatedByNavigation = new HashSet<StocklessPurchase>();
            StocklessPurchaseDeletedByNavigation = new HashSet<StocklessPurchase>();
            StocklessPurchaseModifiedByNavigation = new HashSet<StocklessPurchase>();
            StocklessPurchaseReturnCreatedByNavigation = new HashSet<StocklessPurchaseReturn>();
            StocklessPurchaseReturnDeletedByNavigation = new HashSet<StocklessPurchaseReturn>();
            StocklessPurchaseReturnModifiedByNavigation = new HashSet<StocklessPurchaseReturn>();
            StocklessSaleReturnCreatedByNavigation = new HashSet<StocklessSaleReturn>();
            StocklessSaleReturnDeletedByNavigation = new HashSet<StocklessSaleReturn>();
            StocklessSaleReturnModifiedByNavigation = new HashSet<StocklessSaleReturn>();
            SubcategoryCreatedByNavigation = new HashSet<Subcategory>();
            SubcategoryDeletedByNavigation = new HashSet<Subcategory>();
            SubcategoryModifiedByNavigation = new HashSet<Subcategory>();
            SubscriptionCreatedByNavigation = new HashSet<Subscription>();
            SubscriptionDeletedByNavigation = new HashSet<Subscription>();
            SubscriptionModifiedByNavigation = new HashSet<Subscription>();
            SubscriptionPaymentCreatedByNavigation = new HashSet<SubscriptionPayment>();
            SubscriptionPaymentDeletedByNavigation = new HashSet<SubscriptionPayment>();
            SubscriptionPaymentModifiedByNavigation = new HashSet<SubscriptionPayment>();
            SupplierCategoryCreatedByNavigation = new HashSet<SupplierCategory>();
            SupplierCategoryDeletedByNavigation = new HashSet<SupplierCategory>();
            SupplierCategoryModifiedByNavigation = new HashSet<SupplierCategory>();
            SupplierCreatedByNavigation = new HashSet<Supplier>();
            SupplierDeletedByNavigation = new HashSet<Supplier>();
            SupplierModifiedByNavigation = new HashSet<Supplier>();
            TenantCreatedByNavigation = new HashSet<Tenant>();
            TenantDeletedByNavigation = new HashSet<Tenant>();
            TenantModifiedByNavigation = new HashSet<Tenant>();
            TimeLogCreatedByNavigation = new HashSet<TimeLog>();
            TimeLogDeletedByNavigation = new HashSet<TimeLog>();
            TimeLogModifiedByNavigation = new HashSet<TimeLog>();
            TimeSheetCreatedByNavigation = new HashSet<TimeSheet>();
            TimeSheetDeletedByNavigation = new HashSet<TimeSheet>();
            TimeSheetModifiedByNavigation = new HashSet<TimeSheet>();
            TransferCarrierCreatedByNavigation = new HashSet<TransferCarrier>();
            TransferCarrierDeletedByNavigation = new HashSet<TransferCarrier>();
            TransferCarrierModifiedByNavigation = new HashSet<TransferCarrier>();
            WarehouseCreatedByNavigation = new HashSet<Warehouse>();
            WarehouseDeletedByNavigation = new HashSet<Warehouse>();
            WarehouseModifiedByNavigation = new HashSet<Warehouse>();
            WastageStockCreatedByNavigation = new HashSet<WastageStock>();
            WastageStockDeletedByNavigation = new HashSet<WastageStock>();
            WastageStockModifiedByNavigation = new HashSet<WastageStock>();
        }

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BranchId { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
        public string TenantId { get; set; }
        public string TenantName { get; set; }
        public string CompanyId { get; set; }
        public string EmailConfirmationCode { get; set; }
        public string EmployeeId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsLocked { get; set; }
        public bool IsPasswordExpired { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public DateTime? EmailConfirmationCodeExpireTime { get; set; }
        public DateTime? PhoneConfirmationCodeExpireTime { get; set; }
        public string IpAddress { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
        public DateTime? Deleted { get; set; }
        public string DeletedBy { get; set; }
        public string DeviceInfo { get; set; }
        public bool IsChangePassword { get; set; }
        public string PasswordChangeConfirmationCode { get; set; }
        public DateTime? PasswordChangeConfirmationCodeExpireTime { get; set; }
        public bool IsChangePhone { get; set; }
        public string AwaitingConfirmPhone { get; set; }
        public string PhoneConfirmationCode { get; set; }
        public bool IsChangeEmail { get; set; }
        public string AwaitingConfirmEmail { get; set; }
        public bool IsShouldChangedPasswordOnNextLogin { get; set; }
        public bool IsEnablePasswordExpiration { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual ICollection<AppPermissions> AppPermissionsCreatedByNavigation { get; set; }
        public virtual ICollection<AppPermissions> AppPermissionsDeletedByNavigation { get; set; }
        public virtual ICollection<AppPermissions> AppPermissionsModifiedByNavigation { get; set; }
        public virtual ICollection<AppResources> AppResourcesCreatedByNavigation { get; set; }
        public virtual ICollection<AppResources> AppResourcesDeletedByNavigation { get; set; }
        public virtual ICollection<AppResources> AppResourcesModifiedByNavigation { get; set; }
        public virtual ICollection<AppRoles> AppRolesCreatedByNavigation { get; set; }
        public virtual ICollection<AppRoles> AppRolesDeletedByNavigation { get; set; }
        public virtual ICollection<AppRoles> AppRolesModifiedByNavigation { get; set; }
        public virtual ICollection<AspNetUserClaims> AspNetUserClaimsCreatedByNavigation { get; set; }
        public virtual ICollection<AspNetUserClaims> AspNetUserClaimsDeletedByNavigation { get; set; }
        public virtual ICollection<AspNetUserClaims> AspNetUserClaimsModifiedByNavigation { get; set; }
        public virtual ICollection<AspNetUserClaims> AspNetUserClaimsUser { get; set; }
        public virtual ICollection<AspNetUserLogins> AspNetUserLoginsCreatedByNavigation { get; set; }
        public virtual ICollection<AspNetUserLogins> AspNetUserLoginsDeletedByNavigation { get; set; }
        public virtual ICollection<AspNetUserLogins> AspNetUserLoginsModifiedByNavigation { get; set; }
        public virtual ICollection<AspNetUserLogins> AspNetUserLoginsUser { get; set; }
        public virtual ICollection<AspNetUserRoles> AspNetUserRolesDeletedByNavigation { get; set; }
        public virtual ICollection<AspNetUserRoles> AspNetUserRolesModifiedByNavigation { get; set; }
        public virtual ICollection<AspNetUserRoles> AspNetUserRolesUser { get; set; }
        public virtual ICollection<Asset> AssetCreatedByNavigation { get; set; }
        public virtual ICollection<Asset> AssetDeletedByNavigation { get; set; }
        public virtual ICollection<Asset> AssetModifiedByNavigation { get; set; }
        public virtual ICollection<AuditLog> AuditLogCreatedByNavigation { get; set; }
        public virtual ICollection<AuditLog> AuditLogDeletedByNavigation { get; set; }
        public virtual ICollection<AuditLog> AuditLogModifiedByNavigation { get; set; }
        public virtual ICollection<BankCheck> BankCheckCreatedByNavigation { get; set; }
        public virtual ICollection<BankCheck> BankCheckDeletedByNavigation { get; set; }
        public virtual ICollection<BankCheck> BankCheckModifiedByNavigation { get; set; }
        public virtual ICollection<Bank> BankCreatedByNavigation { get; set; }
        public virtual ICollection<Bank> BankDeletedByNavigation { get; set; }
        public virtual ICollection<Bank> BankModifiedByNavigation { get; set; }
        public virtual ICollection<Branch> BranchCreatedByNavigation { get; set; }
        public virtual ICollection<Branch> BranchDeletedByNavigation { get; set; }
        public virtual ICollection<Branch> BranchModifiedByNavigation { get; set; }
        public virtual ICollection<Category> CategoryCreatedByNavigation { get; set; }
        public virtual ICollection<Category> CategoryDeletedByNavigation { get; set; }
        public virtual ICollection<Category> CategoryModifiedByNavigation { get; set; }
        public virtual ICollection<Company> CompanyCreatedByNavigation { get; set; }
        public virtual ICollection<Company> CompanyDeletedByNavigation { get; set; }
        public virtual ICollection<Company> CompanyModifiedByNavigation { get; set; }
        public virtual ICollection<CompanySetting> CompanySettingCreatedByNavigation { get; set; }
        public virtual ICollection<CompanySetting> CompanySettingDeletedByNavigation { get; set; }
        public virtual ICollection<CompanySetting> CompanySettingModifiedByNavigation { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddressCreatedByNavigation { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddressDeletedByNavigation { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddressModifiedByNavigation { get; set; }
        public virtual ICollection<Customer> CustomerCreatedByNavigation { get; set; }
        public virtual ICollection<Customer> CustomerDeletedByNavigation { get; set; }
        public virtual ICollection<Customer> CustomerModifiedByNavigation { get; set; }
        public virtual ICollection<DailyAccountBalance> DailyAccountBalanceCreatedByNavigation { get; set; }
        public virtual ICollection<DailyAccountBalance> DailyAccountBalanceDeletedByNavigation { get; set; }
        public virtual ICollection<DailyAccountBalance> DailyAccountBalanceModifiedByNavigation { get; set; }
        public virtual ICollection<DailyBankAccountBalance> DailyBankAccountBalanceCreatedByNavigation { get; set; }
        public virtual ICollection<DailyBankAccountBalance> DailyBankAccountBalanceDeletedByNavigation { get; set; }
        public virtual ICollection<DailyBankAccountBalance> DailyBankAccountBalanceModifiedByNavigation { get; set; }
        public virtual ICollection<DailyCashAccountBalance> DailyCashAccountBalanceCreatedByNavigation { get; set; }
        public virtual ICollection<DailyCashAccountBalance> DailyCashAccountBalanceDeletedByNavigation { get; set; }
        public virtual ICollection<DailyCashAccountBalance> DailyCashAccountBalanceModifiedByNavigation { get; set; }
        public virtual ICollection<DailyCustomerAccountBalance> DailyCustomerAccountBalanceCreatedByNavigation { get; set; }
        public virtual ICollection<DailyCustomerAccountBalance> DailyCustomerAccountBalanceDeletedByNavigation { get; set; }
        public virtual ICollection<DailyCustomerAccountBalance> DailyCustomerAccountBalanceModifiedByNavigation { get; set; }
        public virtual ICollection<DailyProductStockBalance> DailyProductStockBalanceCreatedByNavigation { get; set; }
        public virtual ICollection<DailyProductStockBalance> DailyProductStockBalanceDeletedByNavigation { get; set; }
        public virtual ICollection<DailyProductStockBalance> DailyProductStockBalanceModifiedByNavigation { get; set; }
        public virtual ICollection<DailyStockBalance> DailyStockBalanceCreatedByNavigation { get; set; }
        public virtual ICollection<DailyStockBalance> DailyStockBalanceDeletedByNavigation { get; set; }
        public virtual ICollection<DailyStockBalance> DailyStockBalanceModifiedByNavigation { get; set; }
        public virtual ICollection<DailySupplierAccountBalance> DailySupplierAccountBalanceCreatedByNavigation { get; set; }
        public virtual ICollection<DailySupplierAccountBalance> DailySupplierAccountBalanceDeletedByNavigation { get; set; }
        public virtual ICollection<DailySupplierAccountBalance> DailySupplierAccountBalanceModifiedByNavigation { get; set; }
        public virtual ICollection<Delivery> DeliveryCreatedByNavigation { get; set; }
        public virtual ICollection<Delivery> DeliveryDeletedByNavigation { get; set; }
        public virtual ICollection<Delivery> DeliveryModifiedByNavigation { get; set; }
        public virtual ICollection<DeliveryProduct> DeliveryProductCreatedByNavigation { get; set; }
        public virtual ICollection<DeliveryProduct> DeliveryProductDeletedByNavigation { get; set; }
        public virtual ICollection<DeliveryProduct> DeliveryProductModifiedByNavigation { get; set; }
        public virtual ICollection<Deposit> DepositCreatedByNavigation { get; set; }
        public virtual ICollection<Deposit> DepositDeletedByNavigation { get; set; }
        public virtual ICollection<DepositDetail> DepositDetailCreatedByNavigation { get; set; }
        public virtual ICollection<DepositDetail> DepositDetailDeletedByNavigation { get; set; }
        public virtual ICollection<DepositDetail> DepositDetailModifiedByNavigation { get; set; }
        public virtual ICollection<DepositHead> DepositHeadCreatedByNavigation { get; set; }
        public virtual ICollection<DepositHead> DepositHeadDeletedByNavigation { get; set; }
        public virtual ICollection<DepositHead> DepositHeadModifiedByNavigation { get; set; }
        public virtual ICollection<Deposit> DepositModifiedByNavigation { get; set; }
        public virtual ICollection<Edition> EditionCreatedByNavigation { get; set; }
        public virtual ICollection<Edition> EditionDeletedByNavigation { get; set; }
        public virtual ICollection<Edition> EditionModifiedByNavigation { get; set; }
        public virtual ICollection<EmailLog> EmailLogCreatedByNavigation { get; set; }
        public virtual ICollection<EmailLog> EmailLogDeletedByNavigation { get; set; }
        public virtual ICollection<EmailLog> EmailLogModifiedByNavigation { get; set; }
        public virtual ICollection<Employee> EmployeeCreatedByNavigation { get; set; }
        public virtual ICollection<Employee> EmployeeDeletedByNavigation { get; set; }
        public virtual ICollection<Employee> EmployeeModifiedByNavigation { get; set; }
        public virtual ICollection<Equity> EquityCreatedByNavigation { get; set; }
        public virtual ICollection<Equity> EquityDeletedByNavigation { get; set; }
        public virtual ICollection<Equity> EquityModifiedByNavigation { get; set; }
        public virtual ICollection<Expense> ExpenseCreatedByNavigation { get; set; }
        public virtual ICollection<Expense> ExpenseDeletedByNavigation { get; set; }
        public virtual ICollection<ExpenseDetail> ExpenseDetailCreatedByNavigation { get; set; }
        public virtual ICollection<ExpenseDetail> ExpenseDetailDeletedByNavigation { get; set; }
        public virtual ICollection<ExpenseDetail> ExpenseDetailModifiedByNavigation { get; set; }
        public virtual ICollection<ExpenseHead> ExpenseHeadCreatedByNavigation { get; set; }
        public virtual ICollection<ExpenseHead> ExpenseHeadDeletedByNavigation { get; set; }
        public virtual ICollection<ExpenseHead> ExpenseHeadModifiedByNavigation { get; set; }
        public virtual ICollection<Expense> ExpenseModifiedByNavigation { get; set; }
        public virtual ICollection<Feature> FeatureCreatedByNavigation { get; set; }
        public virtual ICollection<Feature> FeatureDeletedByNavigation { get; set; }
        public virtual ICollection<Feature> FeatureModifiedByNavigation { get; set; }
        public virtual ICollection<FiscalYear> FiscalYearCreatedByNavigation { get; set; }
        public virtual ICollection<FiscalYear> FiscalYearDeletedByNavigation { get; set; }
        public virtual ICollection<FiscalYear> FiscalYearModifiedByNavigation { get; set; }
        public virtual ICollection<AspNetUsers> InverseCreatedByNavigation { get; set; }
        public virtual ICollection<AspNetUsers> InverseDeletedByNavigation { get; set; }
        public virtual ICollection<AspNetUsers> InverseModifiedByNavigation { get; set; }
        public virtual ICollection<LoginAttempt> LoginAttemptCreatedByNavigation { get; set; }
        public virtual ICollection<LoginAttempt> LoginAttemptDeletedByNavigation { get; set; }
        public virtual ICollection<LoginAttempt> LoginAttemptModifiedByNavigation { get; set; }
        public virtual ICollection<MonthlyEmailBalance> MonthlyEmailBalanceCreatedByNavigation { get; set; }
        public virtual ICollection<MonthlyEmailBalance> MonthlyEmailBalanceDeletedByNavigation { get; set; }
        public virtual ICollection<MonthlyEmailBalance> MonthlyEmailBalanceModifiedByNavigation { get; set; }
        public virtual ICollection<OpeningStock> OpeningStockCreatedByNavigation { get; set; }
        public virtual ICollection<OpeningStock> OpeningStockDeletedByNavigation { get; set; }
        public virtual ICollection<OpeningStock> OpeningStockModifiedByNavigation { get; set; }
        public virtual ICollection<Partner> PartnerCreatedByNavigation { get; set; }
        public virtual ICollection<Partner> PartnerDeletedByNavigation { get; set; }
        public virtual ICollection<Partner> PartnerModifiedByNavigation { get; set; }
        public virtual ICollection<Product> ProductCreatedByNavigation { get; set; }
        public virtual ICollection<Product> ProductDeletedByNavigation { get; set; }
        public virtual ICollection<Product> ProductModifiedByNavigation { get; set; }
        public virtual ICollection<ProductPrice> ProductPriceCreatedByNavigation { get; set; }
        public virtual ICollection<ProductPrice> ProductPriceDeletedByNavigation { get; set; }
        public virtual ICollection<ProductPrice> ProductPriceModifiedByNavigation { get; set; }
        public virtual ICollection<PurchaseCommissionSetup> PurchaseCommissionSetupCreatedByNavigation { get; set; }
        public virtual ICollection<PurchaseCommissionSetup> PurchaseCommissionSetupDeletedByNavigation { get; set; }
        public virtual ICollection<PurchaseCommissionSetup> PurchaseCommissionSetupModifiedByNavigation { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrderCreatedByNavigation { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrderDeletedByNavigation { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrderModifiedByNavigation { get; set; }
        public virtual ICollection<PurchaseOrderPayment> PurchaseOrderPaymentCreatedByNavigation { get; set; }
        public virtual ICollection<PurchaseOrderPayment> PurchaseOrderPaymentDeletedByNavigation { get; set; }
        public virtual ICollection<PurchaseOrderPayment> PurchaseOrderPaymentModifiedByNavigation { get; set; }
        public virtual ICollection<PurchaseOrderProduct> PurchaseOrderProductCreatedByNavigation { get; set; }
        public virtual ICollection<PurchaseOrderProduct> PurchaseOrderProductDeletedByNavigation { get; set; }
        public virtual ICollection<PurchaseOrderProduct> PurchaseOrderProductModifiedByNavigation { get; set; }
        public virtual ICollection<PurchaseReceive> PurchaseReceiveCreatedByNavigation { get; set; }
        public virtual ICollection<PurchaseReceive> PurchaseReceiveDeletedByNavigation { get; set; }
        public virtual ICollection<PurchaseReceive> PurchaseReceiveModifiedByNavigation { get; set; }
        public virtual ICollection<PurchaseReceiveProduct> PurchaseReceiveProductCreatedByNavigation { get; set; }
        public virtual ICollection<PurchaseReceiveProduct> PurchaseReceiveProductDeletedByNavigation { get; set; }
        public virtual ICollection<PurchaseReceiveProduct> PurchaseReceiveProductModifiedByNavigation { get; set; }
        public virtual ICollection<PurchaseReturn> PurchaseReturnCreatedByNavigation { get; set; }
        public virtual ICollection<PurchaseReturn> PurchaseReturnDeletedByNavigation { get; set; }
        public virtual ICollection<PurchaseReturn> PurchaseReturnModifiedByNavigation { get; set; }
        public virtual ICollection<PurchaseReturnProduct> PurchaseReturnProductCreatedByNavigation { get; set; }
        public virtual ICollection<PurchaseReturnProduct> PurchaseReturnProductDeletedByNavigation { get; set; }
        public virtual ICollection<PurchaseReturnProduct> PurchaseReturnProductModifiedByNavigation { get; set; }
        public virtual ICollection<Rfq> RfqCreatedByNavigation { get; set; }
        public virtual ICollection<Rfq> RfqDeletedByNavigation { get; set; }
        public virtual ICollection<Rfq> RfqModifiedByNavigation { get; set; }
        public virtual ICollection<SaleCommissionSetup> SaleCommissionSetupCreatedByNavigation { get; set; }
        public virtual ICollection<SaleCommissionSetup> SaleCommissionSetupDeletedByNavigation { get; set; }
        public virtual ICollection<SaleCommissionSetup> SaleCommissionSetupModifiedByNavigation { get; set; }
        public virtual ICollection<Sale> SaleCreatedByNavigation { get; set; }
        public virtual ICollection<Sale> SaleDeletedByNavigation { get; set; }
        public virtual ICollection<Sale> SaleModifiedByNavigation { get; set; }
        public virtual ICollection<SalePayment> SalePaymentCreatedByNavigation { get; set; }
        public virtual ICollection<SalePayment> SalePaymentDeletedByNavigation { get; set; }
        public virtual ICollection<SalePayment> SalePaymentModifiedByNavigation { get; set; }
        public virtual ICollection<SaleProduct> SaleProductCreatedByNavigation { get; set; }
        public virtual ICollection<SaleProduct> SaleProductDeletedByNavigation { get; set; }
        public virtual ICollection<SaleProduct> SaleProductModifiedByNavigation { get; set; }
        public virtual ICollection<SaleReturn> SaleReturnCreatedByNavigation { get; set; }
        public virtual ICollection<SaleReturn> SaleReturnDeletedByNavigation { get; set; }
        public virtual ICollection<SaleReturn> SaleReturnModifiedByNavigation { get; set; }
        public virtual ICollection<SaleReturnProduct> SaleReturnProductCreatedByNavigation { get; set; }
        public virtual ICollection<SaleReturnProduct> SaleReturnProductDeletedByNavigation { get; set; }
        public virtual ICollection<SaleReturnProduct> SaleReturnProductModifiedByNavigation { get; set; }
        public virtual ICollection<Scheduler> SchedulerCreatedByNavigation { get; set; }
        public virtual ICollection<Scheduler> SchedulerDeletedByNavigation { get; set; }
        public virtual ICollection<Scheduler> SchedulerModifiedByNavigation { get; set; }
        public virtual ICollection<Stock> StockCreatedByNavigation { get; set; }
        public virtual ICollection<Stock> StockDeletedByNavigation { get; set; }
        public virtual ICollection<Stock> StockModifiedByNavigation { get; set; }
        public virtual ICollection<StockTransfer> StockTransferCreatedByNavigation { get; set; }
        public virtual ICollection<StockTransfer> StockTransferDeletedByNavigation { get; set; }
        public virtual ICollection<StockTransfer> StockTransferModifiedByNavigation { get; set; }
        public virtual ICollection<StockTransferOrder> StockTransferOrderCreatedByNavigation { get; set; }
        public virtual ICollection<StockTransferOrder> StockTransferOrderDeletedByNavigation { get; set; }
        public virtual ICollection<StockTransferOrder> StockTransferOrderModifiedByNavigation { get; set; }
        public virtual ICollection<StockTransferOrderProduct> StockTransferOrderProductCreatedByNavigation { get; set; }
        public virtual ICollection<StockTransferOrderProduct> StockTransferOrderProductDeletedByNavigation { get; set; }
        public virtual ICollection<StockTransferOrderProduct> StockTransferOrderProductModifiedByNavigation { get; set; }
        public virtual ICollection<StockTransferReceive> StockTransferReceiveCreatedByNavigation { get; set; }
        public virtual ICollection<StockTransferReceive> StockTransferReceiveDeletedByNavigation { get; set; }
        public virtual ICollection<StockTransferReceive> StockTransferReceiveModifiedByNavigation { get; set; }
        public virtual ICollection<StockTransferReceiveProduct> StockTransferReceiveProductCreatedByNavigation { get; set; }
        public virtual ICollection<StockTransferReceiveProduct> StockTransferReceiveProductDeletedByNavigation { get; set; }
        public virtual ICollection<StockTransferReceiveProduct> StockTransferReceiveProductModifiedByNavigation { get; set; }
        public virtual ICollection<StocklessPurchase> StocklessPurchaseCreatedByNavigation { get; set; }
        public virtual ICollection<StocklessPurchase> StocklessPurchaseDeletedByNavigation { get; set; }
        public virtual ICollection<StocklessPurchase> StocklessPurchaseModifiedByNavigation { get; set; }
        public virtual ICollection<StocklessPurchaseReturn> StocklessPurchaseReturnCreatedByNavigation { get; set; }
        public virtual ICollection<StocklessPurchaseReturn> StocklessPurchaseReturnDeletedByNavigation { get; set; }
        public virtual ICollection<StocklessPurchaseReturn> StocklessPurchaseReturnModifiedByNavigation { get; set; }
        public virtual ICollection<StocklessSaleReturn> StocklessSaleReturnCreatedByNavigation { get; set; }
        public virtual ICollection<StocklessSaleReturn> StocklessSaleReturnDeletedByNavigation { get; set; }
        public virtual ICollection<StocklessSaleReturn> StocklessSaleReturnModifiedByNavigation { get; set; }
        public virtual ICollection<Subcategory> SubcategoryCreatedByNavigation { get; set; }
        public virtual ICollection<Subcategory> SubcategoryDeletedByNavigation { get; set; }
        public virtual ICollection<Subcategory> SubcategoryModifiedByNavigation { get; set; }
        public virtual ICollection<Subscription> SubscriptionCreatedByNavigation { get; set; }
        public virtual ICollection<Subscription> SubscriptionDeletedByNavigation { get; set; }
        public virtual ICollection<Subscription> SubscriptionModifiedByNavigation { get; set; }
        public virtual ICollection<SubscriptionPayment> SubscriptionPaymentCreatedByNavigation { get; set; }
        public virtual ICollection<SubscriptionPayment> SubscriptionPaymentDeletedByNavigation { get; set; }
        public virtual ICollection<SubscriptionPayment> SubscriptionPaymentModifiedByNavigation { get; set; }
        public virtual ICollection<SupplierCategory> SupplierCategoryCreatedByNavigation { get; set; }
        public virtual ICollection<SupplierCategory> SupplierCategoryDeletedByNavigation { get; set; }
        public virtual ICollection<SupplierCategory> SupplierCategoryModifiedByNavigation { get; set; }
        public virtual ICollection<Supplier> SupplierCreatedByNavigation { get; set; }
        public virtual ICollection<Supplier> SupplierDeletedByNavigation { get; set; }
        public virtual ICollection<Supplier> SupplierModifiedByNavigation { get; set; }
        public virtual ICollection<Tenant> TenantCreatedByNavigation { get; set; }
        public virtual ICollection<Tenant> TenantDeletedByNavigation { get; set; }
        public virtual ICollection<Tenant> TenantModifiedByNavigation { get; set; }
        public virtual ICollection<TimeLog> TimeLogCreatedByNavigation { get; set; }
        public virtual ICollection<TimeLog> TimeLogDeletedByNavigation { get; set; }
        public virtual ICollection<TimeLog> TimeLogModifiedByNavigation { get; set; }
        public virtual ICollection<TimeSheet> TimeSheetCreatedByNavigation { get; set; }
        public virtual ICollection<TimeSheet> TimeSheetDeletedByNavigation { get; set; }
        public virtual ICollection<TimeSheet> TimeSheetModifiedByNavigation { get; set; }
        public virtual ICollection<TransferCarrier> TransferCarrierCreatedByNavigation { get; set; }
        public virtual ICollection<TransferCarrier> TransferCarrierDeletedByNavigation { get; set; }
        public virtual ICollection<TransferCarrier> TransferCarrierModifiedByNavigation { get; set; }
        public virtual ICollection<Warehouse> WarehouseCreatedByNavigation { get; set; }
        public virtual ICollection<Warehouse> WarehouseDeletedByNavigation { get; set; }
        public virtual ICollection<Warehouse> WarehouseModifiedByNavigation { get; set; }
        public virtual ICollection<WastageStock> WastageStockCreatedByNavigation { get; set; }
        public virtual ICollection<WastageStock> WastageStockDeletedByNavigation { get; set; }
        public virtual ICollection<WastageStock> WastageStockModifiedByNavigation { get; set; }
    }
}
