using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class TransectionLog
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string EntityId { get; set; }
        public int EntityType { get; set; }
        public string Data { get; set; }
        public int ActionType { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string BranchId { get; set; }
        public string EntityInvoiceNo { get; set; }
    }
}
