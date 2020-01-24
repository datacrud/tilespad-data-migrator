using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class PurchaseOrder
    {
        public PurchaseOrder()
        {
            ProductPrice = new HashSet<ProductPrice>();
            PurchaseOrderPayment = new HashSet<PurchaseOrderPayment>();
            PurchaseOrderProduct = new HashSet<PurchaseOrderProduct>();
            PurchaseReceive = new HashSet<PurchaseReceive>();
            PurchaseReceiveProduct = new HashSet<PurchaseReceiveProduct>();
        }

        public string Id { get; set; }
        public int Identity { get; set; }
        public DateTime Date { get; set; }
        public string OrderNumber { get; set; }
        public string SupplierId { get; set; }
        public string EmployeeId { get; set; }
        public string Note { get; set; }
        public double Comission { get; set; }
        public double CarryingCharge { get; set; }
        public double OrderTotalBox { get; set; }
        public double OrderTotalQuantity { get; set; }
        public double OrderTotalSquarefit { get; set; }
        public double OrderTotalActualSquarefit { get; set; }
        public double OrderTotalPrice { get; set; }
        public int Status { get; set; }
        public double TotalPayable { get; set; }
        public double TotalPaid { get; set; }
        public double TotalDiscount { get; set; }
        public double TotalDue { get; set; }
        public bool IsMarkResolved { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string BranchId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? Deleted { get; set; }
        public string DeletedBy { get; set; }
        public string TenantId { get; set; }
        public string CompanyId { get; set; }
        public string DeviceInfo { get; set; }
        public string IpAddress { get; set; }
        public int? Order { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Tenant Tenant { get; set; }
        public virtual ICollection<ProductPrice> ProductPrice { get; set; }
        public virtual ICollection<PurchaseOrderPayment> PurchaseOrderPayment { get; set; }
        public virtual ICollection<PurchaseOrderProduct> PurchaseOrderProduct { get; set; }
        public virtual ICollection<PurchaseReceive> PurchaseReceive { get; set; }
        public virtual ICollection<PurchaseReceiveProduct> PurchaseReceiveProduct { get; set; }
    }
}
