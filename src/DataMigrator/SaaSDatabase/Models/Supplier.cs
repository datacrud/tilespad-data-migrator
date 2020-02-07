using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            DailySupplierAccountBalance = new HashSet<DailySupplierAccountBalance>();
            OpeningStock = new HashSet<OpeningStock>();
            PurchaseCommissionSetup = new HashSet<PurchaseCommissionSetup>();
            PurchaseOrder = new HashSet<PurchaseOrder>();
            PurchaseReceive = new HashSet<PurchaseReceive>();
            PurchaseReturn = new HashSet<PurchaseReturn>();
            Stock = new HashSet<Stock>();
            StockTransfer = new HashSet<StockTransfer>();
            StocklessPurchase = new HashSet<StocklessPurchase>();
            StocklessPurchaseReturn = new HashSet<StocklessPurchaseReturn>();
            SupplierCategory = new HashSet<SupplierCategory>();
            WastageStock = new HashSet<WastageStock>();
        }

        public string Id { get; set; }
        public int? Type { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public double TotalBox { get; set; }
        public double TotalQuantity { get; set; }
        public double TotalSquarefit { get; set; }
        public double OpeningDue { get; set; }
        public double TotalReceivable { get; set; }
        public double TotalPaid { get; set; }
        public double TotalDiscount { get; set; }
        public double TotalDue { get; set; }
        public string Note { get; set; }
        public double MonthlyComissionRate { get; set; }
        public double QuaterComissionRate { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string BranchId { get; set; }
        public double ActualDue { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? Deleted { get; set; }
        public string DeletedBy { get; set; }
        public string TenantId { get; set; }
        public string CompanyId { get; set; }
        public string DeviceInfo { get; set; }
        public string IpAddress { get; set; }
        public bool HasMonthlyBrokenAdjustment { get; set; }
        public int MonthlyBrokenAdjustmentAs { get; set; }
        public double MonthlyBrokenAdjustmentValue { get; set; }
        public bool HasQuarterlyBrokenAdjustment { get; set; }
        public int QuarterlyBrokenAdjustmentAs { get; set; }
        public double QuarterlyBrokenAdjustmentValue { get; set; }
        public bool HasHalfYearlyBrokenAdjustment { get; set; }
        public int HalfYearlyBrokenAdjustmentAs { get; set; }
        public double HalfYearlyBrokenAdjustmentValue { get; set; }
        public bool HasYearlyBrokenAdjustment { get; set; }
        public int YearlyBrokenAdjustmentAs { get; set; }
        public double YearlyBrokenAdjustmentValue { get; set; }
        public bool CaluclateComissionBasedOnTotalSquarefit { get; set; }
        public bool HasTaxAdjustmentOnTotalComission { get; set; }
        public int TaxAdjustmentAs { get; set; }
        public double TaxAdjustmentValue { get; set; }
        public int? Order { get; set; }
        public string OriginalPk { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual Tenant Tenant { get; set; }
        public virtual ICollection<DailySupplierAccountBalance> DailySupplierAccountBalance { get; set; }
        public virtual ICollection<OpeningStock> OpeningStock { get; set; }
        public virtual ICollection<PurchaseCommissionSetup> PurchaseCommissionSetup { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrder { get; set; }
        public virtual ICollection<PurchaseReceive> PurchaseReceive { get; set; }
        public virtual ICollection<PurchaseReturn> PurchaseReturn { get; set; }
        public virtual ICollection<Stock> Stock { get; set; }
        public virtual ICollection<StockTransfer> StockTransfer { get; set; }
        public virtual ICollection<StocklessPurchase> StocklessPurchase { get; set; }
        public virtual ICollection<StocklessPurchaseReturn> StocklessPurchaseReturn { get; set; }
        public virtual ICollection<SupplierCategory> SupplierCategory { get; set; }
        public virtual ICollection<WastageStock> WastageStock { get; set; }
    }
}
