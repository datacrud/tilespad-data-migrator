using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class SubscriptionPayment
    {
        public string Id { get; set; }
        public string SubscriptionId { get; set; }
        public int PaymentMethod { get; set; }
        public double SubscriptionCharge { get; set; }
        public double ServiceCharge { get; set; }
        public double AmountToBePaid { get; set; }
        public double PaidAmount { get; set; }
        public string TransectionNumber { get; set; }
        public string VerificationCode { get; set; }
        public string PaymentReferance { get; set; }
        public int PaymentStatus { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? Deleted { get; set; }
        public string DeletedBy { get; set; }
        public string TenantId { get; set; }
        public string CompanyId { get; set; }
        public DateTime? Date { get; set; }
        public string DeviceInfo { get; set; }
        public string IpAddress { get; set; }
        public int? Order { get; set; }
        public string OriginalPk { get; set; }

        public virtual Company Company { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual Subscription Subscription { get; set; }
        public virtual Tenant Tenant { get; set; }
    }
}
