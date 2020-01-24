using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class Subscription
    {
        public Subscription()
        {
            SubscriptionPayment = new HashSet<SubscriptionPayment>();
        }

        public string Id { get; set; }
        public string EditionId { get; set; }
        public DateTime? ExpireOn { get; set; }
        public int Package { get; set; }
        public double Price { get; set; }
        public DateTime? RenewedOn { get; set; }
        public int Status { get; set; }
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
        public int PaymentStatus { get; set; }
        public bool IsPaymentCompleted { get; set; }
        public string DeviceInfo { get; set; }
        public string IpAddress { get; set; }
        public string TenantName { get; set; }
        public double PackageMonthlyPrice { get; set; }
        public int PackageMonth { get; set; }
        public int NoOfShowroom { get; set; }
        public double PackageDiscountPercentage { get; set; }
        public double PackageDiscountAmount { get; set; }
        public double PackageCharge { get; set; }
        public int? Order { get; set; }

        public virtual Company Company { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual Edition Edition { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual Tenant Tenant { get; set; }
        public virtual ICollection<SubscriptionPayment> SubscriptionPayment { get; set; }
    }
}
