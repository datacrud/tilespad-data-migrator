using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class Equity
    {
        public string Id { get; set; }
        public string OwnerName { get; set; }
        public double EquityValue { get; set; }
        public string Note { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string BranchId { get; set; }
        public int OwnershipType { get; set; }
    }
}
