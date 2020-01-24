using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class Bank
    {
        public Bank()
        {
            DailyBankAccountBalance = new HashSet<DailyBankAccountBalance>();
        }

        public string Id { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public int AccountType { get; set; }
        public double LoanPercentage { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public double OpeningBalance { get; set; }
        public double CurrentBalance { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string BranchId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? Deleted { get; set; }
        public string DeletedBy { get; set; }
        public string TenantId { get; set; }
        public string CompanyId { get; set; }
        public string DeviceInfo { get; set; }
        public string IpAddress { get; set; }
        public int? Order { get; set; }
        public string BranchName { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual Tenant Tenant { get; set; }
        public virtual ICollection<DailyBankAccountBalance> DailyBankAccountBalance { get; set; }
    }
}
