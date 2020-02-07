using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class SalePayment
    {
        public string Id { get; set; }
        public string SaleId { get; set; }
        public DateTime Date { get; set; }
        public int PaymentMethod { get; set; }
        public string BankId { get; set; }
        public string BankCheckId { get; set; }
        public double Paid { get; set; }
        public double Due { get; set; }
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
        public string OriginalPk { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual Sale Sale { get; set; }
        public virtual Tenant Tenant { get; set; }
    }
}
