using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class DailySupplierAccountBalance
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string SupplierId { get; set; }
        public double OpeningPayable { get; set; }
        public double ClosingPayable { get; set; }
        public double OpeningPurchase { get; set; }
        public double ClosingPurchase { get; set; }
        public double OpeningReturn { get; set; }
        public double ClosingReturn { get; set; }
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
        public virtual Supplier Supplier { get; set; }
        public virtual Tenant Tenant { get; set; }
    }
}
