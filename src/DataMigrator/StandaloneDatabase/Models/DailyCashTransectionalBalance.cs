using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class DailyCashTransectionalBalance
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public double OpeningBalance { get; set; }
        public double ClosingBalance { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string BranchId { get; set; }
    }
}
