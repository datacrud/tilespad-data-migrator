using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class CustomerAddress
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public string Territory { get; set; }
        public string Address { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool Active { get; set; }
        public string BranchId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
