using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class Partner
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public DateTime PartnerFrom { get; set; }
        public double PrimaryContribution { get; set; }
        public string Importance { get; set; }
        public string Note { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string BranchId { get; set; }
    }
}
