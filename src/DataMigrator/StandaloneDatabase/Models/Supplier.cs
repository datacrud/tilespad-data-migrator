using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            ComissionSetup = new HashSet<ComissionSetup>();
            DailySupplierTransectionalBalance = new HashSet<DailySupplierTransectionalBalance>();
            OpeningStock = new HashSet<OpeningStock>();
            PurchaseOrder = new HashSet<PurchaseOrder>();
            PurchaseReceive = new HashSet<PurchaseReceive>();
            PurchaseReturn = new HashSet<PurchaseReturn>();
            Stock = new HashSet<Stock>();
            StockTransfer = new HashSet<StockTransfer>();
            SupplierCategory = new HashSet<SupplierCategory>();
            WestageStock = new HashSet<WestageStock>();
        }

        public string Id { get; set; }
        public int Type { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public double TotalQuantity { get; set; }
        public double OpeningDue { get; set; }
        public double TotalReceivable { get; set; }
        public double TotalPaid { get; set; }
        public double TotalDue { get; set; }
        public string Note { get; set; }
        public int Identity { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool Active { get; set; }
        public double TotalBox { get; set; }
        public double TotalSquarefit { get; set; }
        public double TotalDiscount { get; set; }
        public double MonthlyComissionRate { get; set; }
        public double QuaterComissionRate { get; set; }
        public string BranchId { get; set; }
        public double ActualDue { get; set; }
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

        public virtual ICollection<ComissionSetup> ComissionSetup { get; set; }
        public virtual ICollection<DailySupplierTransectionalBalance> DailySupplierTransectionalBalance { get; set; }
        public virtual ICollection<OpeningStock> OpeningStock { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrder { get; set; }
        public virtual ICollection<PurchaseReceive> PurchaseReceive { get; set; }
        public virtual ICollection<PurchaseReturn> PurchaseReturn { get; set; }
        public virtual ICollection<Stock> Stock { get; set; }
        public virtual ICollection<StockTransfer> StockTransfer { get; set; }
        public virtual ICollection<SupplierCategory> SupplierCategory { get; set; }
        public virtual ICollection<WestageStock> WestageStock { get; set; }
    }
}
