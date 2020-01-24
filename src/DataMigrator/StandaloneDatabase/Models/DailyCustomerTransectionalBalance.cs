using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class DailyCustomerTransectionalBalance
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public double OpeningReceiveable { get; set; }
        public double ClosingReceiveable { get; set; }
        public double OpeningSale { get; set; }
        public double ClosingSale { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime Date { get; set; }
        public double OpeningReturn { get; set; }
        public double ClosingReturn { get; set; }
        public string BranchId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
