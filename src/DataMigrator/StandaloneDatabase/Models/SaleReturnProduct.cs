using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class SaleReturnProduct
    {
        public string Id { get; set; }
        public string SaleReturnId { get; set; }
        public string WarehouseId { get; set; }
        public string CategoryId { get; set; }
        public string SupplierCategoryId { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int Box { get; set; }
        public int Quantity { get; set; }
        public double Squarefit { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool Active { get; set; }
        public DateTime Date { get; set; }
        public string BranchId { get; set; }
        public string SubcategoryId { get; set; }
        public double ProfitLossAdjustmentAmount { get; set; }
        public bool IsProfitLoassAdjustmentCalculated { get; set; }
        public double Discount { get; set; }

        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
        public virtual SaleReturn SaleReturn { get; set; }
        public virtual Subcategory Subcategory { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
