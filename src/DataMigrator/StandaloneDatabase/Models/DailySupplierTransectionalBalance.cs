using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class DailySupplierTransectionalBalance
    {
        public string Id { get; set; }
        public string SupplierId { get; set; }
        public double OpeningPayable { get; set; }
        public double ClosingPayable { get; set; }
        public double OpeningPurchase { get; set; }
        public double ClosingPurchase { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime Date { get; set; }
        public double OpeningReturn { get; set; }
        public double ClosingReturn { get; set; }
        public string BranchId { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
