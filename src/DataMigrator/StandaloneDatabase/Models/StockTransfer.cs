using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class StockTransfer
    {
        public string Id { get; set; }
        public string SourceWarehouseId { get; set; }
        public string DestinationWarehouseId { get; set; }
        public string SupplierId { get; set; }
        public string SupplierCategoryId { get; set; }
        public string ProductId { get; set; }
        public int TransferBox { get; set; }
        public int TransferQuantity { get; set; }
        public double TransferSquarefit { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool Active { get; set; }
        public string CategoryId { get; set; }
        public double TransferValue { get; set; }
        public string BranchId { get; set; }
        public string SubcategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Warehouse DestinationWarehouse { get; set; }
        public virtual Product Product { get; set; }
        public virtual Warehouse SourceWarehouse { get; set; }
        public virtual Subcategory Subcategory { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
