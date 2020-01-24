using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class SupplierCategory
    {
        public string Id { get; set; }
        public int Identity { get; set; }
        public string SupplierId { get; set; }
        public string CategoryId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool Active { get; set; }
        public bool HasYearlyPoint { get; set; }
        public double YearlyPointPerSquarefit { get; set; }
        public string BranchId { get; set; }
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

        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
        public virtual Subcategory Subcategory { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
