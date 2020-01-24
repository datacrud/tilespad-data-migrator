using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class PurchaseReceive
    {
        public PurchaseReceive()
        {
            PurchaseReceiveProduct = new HashSet<PurchaseReceiveProduct>();
        }

        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string ReceiveNumber { get; set; }
        public string PurchaseOrderId { get; set; }
        public string SupplierId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool Active { get; set; }
        public int Identity { get; set; }
        public string OrderedEmployeeId { get; set; }
        public string Note { get; set; }
        public int OrderedTotalBox { get; set; }
        public int OrderedTotalQuantity { get; set; }
        public double OrderedTotalSquarefit { get; set; }
        public int TotalBox { get; set; }
        public int TotalQuantity { get; set; }
        public double TotalSquarefit { get; set; }
        public int OrderedTotalDueBox { get; set; }
        public int OrderedTotalDueQuantity { get; set; }
        public double OrderedTotalDueSquarefit { get; set; }
        public double TotalReceivedPrice { get; set; }
        public double TotalActualSquarefit { get; set; }
        public string BranchId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Employee OrderedEmployee { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<PurchaseReceiveProduct> PurchaseReceiveProduct { get; set; }
    }
}
