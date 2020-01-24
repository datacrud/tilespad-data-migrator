using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class Stock
    {
        public string Id { get; set; }
        public string WarehouseId { get; set; }
        public string SupplierId { get; set; }
        public string CategoryId { get; set; }
        public string SupplierCategoryId { get; set; }
        public string ProductId { get; set; }
        public int OpeningStockBox { get; set; }
        public int OpeningStockQuantity { get; set; }
        public double OpeningStockSquarefit { get; set; }
        public int CurrentStockBox { get; set; }
        public int CurrentStockQuantity { get; set; }
        public double CurrentStockSquarefit { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool Active { get; set; }
        public double CurrentStockValue { get; set; }
        public string BranchId { get; set; }
        public string SubcategoryId { get; set; }
        public bool IsObsolate { get; set; }

        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
        public virtual Subcategory Subcategory { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
