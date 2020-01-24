using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class BankCheck
    {
        public string Id { get; set; }
        public int TransectionType { get; set; }
        public string TransectionId { get; set; }
        public int PayerType { get; set; }
        public string PayerId { get; set; }
        public DateTime CheckDate { get; set; }
        public string BankName { get; set; }
        public string CheckNumber { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public double TotalAmount { get; set; }
        public string IssuedBy { get; set; }
        public DateTime DueDate { get; set; }
        public string Note { get; set; }
        public int CheckOwner { get; set; }
        public int CheckStatus { get; set; }
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

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual Tenant Tenant { get; set; }
    }
}
