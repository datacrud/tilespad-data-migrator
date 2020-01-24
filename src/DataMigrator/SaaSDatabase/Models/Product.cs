using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class Product
    {
        public Product()
        {
            DeliveryProduct = new HashSet<DeliveryProduct>();
            OpeningStock = new HashSet<OpeningStock>();
            ProductPrice = new HashSet<ProductPrice>();
            PurchaseOrderProduct = new HashSet<PurchaseOrderProduct>();
            PurchaseReceiveProduct = new HashSet<PurchaseReceiveProduct>();
            PurchaseReturnProduct = new HashSet<PurchaseReturnProduct>();
            SaleProduct = new HashSet<SaleProduct>();
            SaleReturnProduct = new HashSet<SaleReturnProduct>();
            Stock = new HashSet<Stock>();
            StockTransfer = new HashSet<StockTransfer>();
            StockTransferOrderProduct = new HashSet<StockTransferOrderProduct>();
            StockTransferReceiveProduct = new HashSet<StockTransferReceiveProduct>();
            SupplierCategory = new HashSet<SupplierCategory>();
            WastageStock = new HashSet<WastageStock>();
        }

        public string Id { get; set; }
        public string CategoryId { get; set; }
        public string SubcategoryId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Grad { get; set; }
        public int Type { get; set; }
        public int QuantityPerBox { get; set; }
        public double PurchaseSquarefitPerBox { get; set; }
        public double SaleableSquarefitPerBox { get; set; }
        public double PurchaseSquarefitPerQuantity { get; set; }
        public double SaleableSquarefitPerQuantity { get; set; }
        public double CostPricePerSquarefit { get; set; }
        public double SalePricePerSquarefit { get; set; }
        public string Note { get; set; }
        public string SupplierId { get; set; }
        public string SupplierCategoryId { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? Deleted { get; set; }
        public string DeletedBy { get; set; }
        public string TenantId { get; set; }
        public string CompanyId { get; set; }
        public string DeviceInfo { get; set; }
        public string IpAddress { get; set; }
        public int? Order { get; set; }
        public double AverageCostPricePerSquareFit { get; set; }
        public double AverageSalePricePerSquareFit { get; set; }
        public bool IsExpired { get; set; }
        public int? MeasurementType { get; set; }

        public virtual Category Category { get; set; }
        public virtual Company Company { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual Subcategory Subcategory { get; set; }
        public virtual Tenant Tenant { get; set; }
        public virtual ICollection<DeliveryProduct> DeliveryProduct { get; set; }
        public virtual ICollection<OpeningStock> OpeningStock { get; set; }
        public virtual ICollection<ProductPrice> ProductPrice { get; set; }
        public virtual ICollection<PurchaseOrderProduct> PurchaseOrderProduct { get; set; }
        public virtual ICollection<PurchaseReceiveProduct> PurchaseReceiveProduct { get; set; }
        public virtual ICollection<PurchaseReturnProduct> PurchaseReturnProduct { get; set; }
        public virtual ICollection<SaleProduct> SaleProduct { get; set; }
        public virtual ICollection<SaleReturnProduct> SaleReturnProduct { get; set; }
        public virtual ICollection<Stock> Stock { get; set; }
        public virtual ICollection<StockTransfer> StockTransfer { get; set; }
        public virtual ICollection<StockTransferOrderProduct> StockTransferOrderProduct { get; set; }
        public virtual ICollection<StockTransferReceiveProduct> StockTransferReceiveProduct { get; set; }
        public virtual ICollection<SupplierCategory> SupplierCategory { get; set; }
        public virtual ICollection<WastageStock> WastageStock { get; set; }
    }
}
