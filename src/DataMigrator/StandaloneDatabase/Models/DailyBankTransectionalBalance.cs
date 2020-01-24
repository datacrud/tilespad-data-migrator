using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class DailyBankTransectionalBalance
    {
        public string Id { get; set; }
        public string BankId { get; set; }
        public double OpeningBalance { get; set; }
        public double ClosingBalance { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime Date { get; set; }
        public string BranchId { get; set; }

        public virtual Bank Bank { get; set; }
    }
}
