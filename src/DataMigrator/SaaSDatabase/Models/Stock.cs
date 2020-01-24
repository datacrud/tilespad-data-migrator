using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class Stock
    {
        public string Id { get; set; }
        public string WarehouseId { get; set; }
        public string SupplierId { get; set; }
        public string CategoryId { get; set; }
        public string SubcategoryId { get; set; }
        public string SupplierCategoryId { get; set; }
        public string ProductId { get; set; }
        public int OpeningStockBox { get; set; }
        public int OpeningStockQuantity { get; set; }
        public double OpeningStockSquarefit { get; set; }
        public int CurrentStockBox { get; set; }
        public int CurrentStockQuantity { get; set; }
        public double CurrentStockSquarefit { get; set; }
        public double CurrentStockValue { get; set; }
        public bool IsObsolate { get; set; }
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
        public virtual Category Category { get; set; }
        public virtual Company Company { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual Product Product { get; set; }
        public virtual Subcategory Subcategory { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Tenant Tenant { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
