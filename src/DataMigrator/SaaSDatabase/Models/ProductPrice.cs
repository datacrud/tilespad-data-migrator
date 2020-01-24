using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class ProductPrice
    {
        public string Id { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string ProductId { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public string PurchaseOrderId { get; set; }
        public string PurchaseReceiveId { get; set; }
        public string CompanyId { get; set; }
        public string TenantId { get; set; }
        public bool Active { get; set; }
        public int? Order { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? Deleted { get; set; }
        public string DeletedBy { get; set; }
        public string DeviceInfo { get; set; }
        public string IpAddress { get; set; }

        public virtual Company Company { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual Product Product { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual PurchaseReceive PurchaseReceive { get; set; }
        public virtual Tenant Tenant { get; set; }
    }
}
