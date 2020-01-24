using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class Branch
    {
        public string Id { get; set; }
        public int Identity { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Type { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string BranchId { get; set; }
        public double OpeningCash { get; set; }
    }
}
