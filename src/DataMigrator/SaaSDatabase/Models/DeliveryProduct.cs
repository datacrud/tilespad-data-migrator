using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class DeliveryProduct
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string DeliveryId { get; set; }
        public string SaleId { get; set; }
        public string WarehouseId { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryId { get; set; }
        public string SupplierCategoryId { get; set; }
        public string Note { get; set; }
        public int SaleOrderedBox { get; set; }
        public int SaleOrderedQuantity { get; set; }
        public double SaleOrderedSquarefit { get; set; }
        public int Box { get; set; }
        public int Quantity { get; set; }
        public double Squarefit { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string BranchId { get; set; }
        public string SubcategoryId { get; set; }
        public int? Order { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? Deleted { get; set; }
        public string DeletedBy { get; set; }
        public string TenantId { get; set; }
        public string CompanyId { get; set; }
        public string DeviceInfo { get; set; }
        public string IpAddress { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Category Category { get; set; }
        public virtual Company Company { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual Delivery Delivery { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual Product Product { get; set; }
        public virtual Sale Sale { get; set; }
        public virtual Subcategory Subcategory { get; set; }
        public virtual Tenant Tenant { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
