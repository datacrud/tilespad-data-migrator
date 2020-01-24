using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class PurchaseOrder
    {
        public PurchaseOrder()
        {
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
        public double OrderTotalBox { get; set; }
        public double OrderTotalQuantity { get; set; }
        public double OrderTotalSquarefit { get; set; }
        public double OrderTotalPrice { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool Active { get; set; }
        public int Status { get; set; }
        public double TotalPayable { get; set; }
        public double TotalPaid { get; set; }
        public double TotalDiscount { get; set; }
        public double TotalDue { get; set; }
        public double OrderTotalActualSquarefit { get; set; }
        public double Comission { get; set; }
        public double CarryingCharge { get; set; }
        public string BranchId { get; set; }
        public bool IsMarkResolved { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<PurchaseOrderPayment> PurchaseOrderPayment { get; set; }
        public virtual ICollection<PurchaseOrderProduct> PurchaseOrderProduct { get; set; }
        public virtual ICollection<PurchaseReceive> PurchaseReceive { get; set; }
        public virtual ICollection<PurchaseReceiveProduct> PurchaseReceiveProduct { get; set; }
    }
}
