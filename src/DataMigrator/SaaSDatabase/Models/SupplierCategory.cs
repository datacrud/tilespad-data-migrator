using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class SupplierCategory
    {
        public string Id { get; set; }
        public int Identity { get; set; }
        public string SupplierId { get; set; }
        public string CategoryId { get; set; }
        public string SubcategoryId { get; set; }
        public bool IsAddAllProducts { get; set; }
        public string ProductId { get; set; }
        public bool IsDefaultSupplier { get; set; }
        public bool OverrideThisProduct { get; set; }
        public string SubcategoryCode { get; set; }
        public string SubcategoryName { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int QuantityPerBox { get; set; }
        public double PurchaseSquarefitPerBox { get; set; }
        public double SaleableSquarefitPerBox { get; set; }
        public double PurchaseSquarefitPerQuantity { get; set; }
        public double SaleableSquarefitPerQuantity { get; set; }
        public double CostPricePerSquarefit { get; set; }
        public double SalePricePerSquarefit { get; set; }
        public bool HasYearlyPoint { get; set; }
        public double YearlyPointPerSquarefit { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
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
        public virtual Category Category { get; set; }
        public virtual Company Company { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual Product Product { get; set; }
        public virtual Subcategory Subcategory { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Tenant Tenant { get; set; }
    }
}
