using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class Edition
    {
        public Edition()
        {
            Feature = new HashSet<Feature>();
            Subscription = new HashSet<Subscription>();
            Tenant = new HashSet<Tenant>();
        }

        public string Id { get; set; }
        public bool IsActive { get; set; }
        public string DisplayName { get; set; }
        public string Name { get; set; }
        public string Descriminator { get; set; }
        public double AnnualPrice { get; set; }
        public double MonthlyPrice { get; set; }
        public int TrialDayCount { get; set; }
        public int WaitingDayAfterExpire { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? Deleted { get; set; }
        public string DeletedBy { get; set; }
        public int? Order { get; set; }
        public string DeviceInfo { get; set; }
        public string IpAddress { get; set; }
        public int DiscountType { get; set; }
        public double AnnualPriceDiscountAmount { get; set; }
        public double AnnualPriceDiscountPercentage { get; set; }
        public double HalfYearlyPriceDiscountAmount { get; set; }
        public double HalfYearlyPriceDiscountPercentage { get; set; }
        public double QuarterPriceDiscountAmount { get; set; }
        public double QuarterPriceDiscountPercentage { get; set; }
        public double MonthlyPriceDiscountAmount { get; set; }
        public double MonthlyPriceDiscountPercentage { get; set; }
        public int MinimumNoOfShowroom { get; set; }
        public int MaximumNoOfShowroom { get; set; }
        public double HalfYearlyPrice { get; set; }
        public double QuarterPrice { get; set; }
        public string OriginalPk { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual ICollection<Feature> Feature { get; set; }
        public virtual ICollection<Subscription> Subscription { get; set; }
        public virtual ICollection<Tenant> Tenant { get; set; }
    }
}
