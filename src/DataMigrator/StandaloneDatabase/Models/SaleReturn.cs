using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class SaleReturn
    {
        public SaleReturn()
        {
            SaleReturnProduct = new HashSet<SaleReturnProduct>();
        }

        public string Id { get; set; }
        public string CustomerId { get; set; }
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

        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<SaleReturnProduct> SaleReturnProduct { get; set; }
    }
}
