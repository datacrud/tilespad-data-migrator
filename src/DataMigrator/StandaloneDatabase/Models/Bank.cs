using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class Bank
    {
        public Bank()
        {
            DailyBankTransectionalBalance = new HashSet<DailyBankTransectionalBalance>();
        }

        public string Id { get; set; }
        public string Branch { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public double OpeningBalance { get; set; }
        public double CurrentBalance { get; set; }
        public int Identity { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool Active { get; set; }
        public int AccountType { get; set; }
        public double LoanPercentage { get; set; }
        public string BranchId { get; set; }

        public virtual ICollection<DailyBankTransectionalBalance> DailyBankTransectionalBalance { get; set; }
    }
}
