using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class PurchaseReturn
    {
        public PurchaseReturn()
        {
            PurchaseReturnProduct = new HashSet<PurchaseReturnProduct>();
        }

        public string Id { get; set; }
        public string SupplierId { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime Date { get; set; }
        public string EmployeeId { get; set; }
        public int TotalBox { get; set; }
        public int TotalQuantity { get; set; }
        public double TotalSquarefit { get; set; }
        public double TotalReturnPrice { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool Active { get; set; }
        public string Note { get; set; }
        public string BranchId { get; set; }
        public double TotalReturnDiscount { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<PurchaseReturnProduct> PurchaseReturnProduct { get; set; }
    }
}
