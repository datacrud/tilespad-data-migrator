using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class StocklessPurchase
    {
        public string Id { get; set; }
        public DateTime? Date { get; set; }
        public string InvoiceNumber { get; set; }
        public string SupplierId { get; set; }
        public string EmployeeId { get; set; }
        public double Comission { get; set; }
        public double CarryingCharge { get; set; }
        public int MeasurementType { get; set; }
        public double PurchaseTotalBox { get; set; }
        public double PurchaseTotalQuantity { get; set; }
        public double PurchaseTotalSquarefit { get; set; }
        public double PurchaseTotalActualSquarefit { get; set; }
        public double PurchaseTotalPrice { get; set; }
        public int PaymentMethod { get; set; }
        public string BankId { get; set; }
        public string BankCheckId { get; set; }
        public double TotalPayable { get; set; }
        public double TotalPaid { get; set; }
        public double TotalDiscount { get; set; }
        public double TotalDue { get; set; }
        public string Note { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? Deleted { get; set; }
        public string DeletedBy { get; set; }
        public string TenantId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string DeviceInfo { get; set; }
        public string IpAddress { get; set; }
        public int? Order { get; set; }
        public string OriginalPk { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Tenant Tenant { get; set; }
    }
}
