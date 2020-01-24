using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class Delivery
    {
        public Delivery()
        {
            DeliveryProduct = new HashSet<DeliveryProduct>();
        }

        public string Id { get; set; }
        public int Identity { get; set; }
        public string DeliveryNumber { get; set; }
        public string SaleId { get; set; }
        public DateTime Date { get; set; }
        public string CustomerId { get; set; }
        public string CustomerPhone { get; set; }
        public string EmployeeId { get; set; }
        public int Status { get; set; }
        public int TotalBox { get; set; }
        public int TotalQuantity { get; set; }
        public double TotalSquarefit { get; set; }
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
        public virtual Customer Customer { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual Sale Sale { get; set; }
        public virtual Tenant Tenant { get; set; }
        public virtual ICollection<DeliveryProduct> DeliveryProduct { get; set; }
    }
}
