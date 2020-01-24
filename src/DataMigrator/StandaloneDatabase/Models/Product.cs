using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class Product
    {
        public Product()
        {
            DeliveryProduct = new HashSet<DeliveryProduct>();
            OpeningStockNavigation = new HashSet<OpeningStock>();
            PurchaseOrderProduct = new HashSet<PurchaseOrderProduct>();
            PurchaseReceiveProduct = new HashSet<PurchaseReceiveProduct>();
            PurchaseReturnProduct = new HashSet<PurchaseReturnProduct>();
            SaleProduct = new HashSet<SaleProduct>();
            SaleReturnProduct = new HashSet<SaleReturnProduct>();
            Stock = new HashSet<Stock>();
            StockTransfer = new HashSet<StockTransfer>();
            SupplierCategory = new HashSet<SupplierCategory>();
            WestageStock = new HashSet<WestageStock>();
        }

        public string Id { get; set; }
        public int Identity { get; set; }
        public string SupplierId { get; set; }
        public string CategoryId { get; set; }
        public string SupplierCategoryId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int QuantityPerBox { get; set; }
        public double PurchaseSquarefitPerQuantity { get; set; }
        public double SaleableSquarefitPerQuantity { get; set; }
        public double CostPricePerSquarefit { get; set; }
        public double SalePricePerSquarefit { get; set; }
        public string Note { get; set; }
        public double OpeningStock { get; set; }
        public double CurrentStock { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool Active { get; set; }
        public double PurchaseSquarefitPerBox { get; set; }
        public double SaleableSquarefitPerBox { get; set; }
        public string BranchId { get; set; }
        public string SubcategoryId { get; set; }
        public int Grad { get; set; }
        public bool IsObsulate { get; set; }
        public string ImageName { get; set; }
        public string ImagePath { get; set; }

        public virtual Category Category { get; set; }
        public virtual Subcategory Subcategory { get; set; }
        public virtual ICollection<DeliveryProduct> DeliveryProduct { get; set; }
        public virtual ICollection<OpeningStock> OpeningStockNavigation { get; set; }
        public virtual ICollection<PurchaseOrderProduct> PurchaseOrderProduct { get; set; }
        public virtual ICollection<PurchaseReceiveProduct> PurchaseReceiveProduct { get; set; }
        public virtual ICollection<PurchaseReturnProduct> PurchaseReturnProduct { get; set; }
        public virtual ICollection<SaleProduct> SaleProduct { get; set; }
        public virtual ICollection<SaleReturnProduct> SaleReturnProduct { get; set; }
        public virtual ICollection<Stock> Stock { get; set; }
        public virtual ICollection<StockTransfer> StockTransfer { get; set; }
        public virtual ICollection<SupplierCategory> SupplierCategory { get; set; }
        public virtual ICollection<WestageStock> WestageStock { get; set; }
    }
}
