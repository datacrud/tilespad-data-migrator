using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class Subcategory
    {
        public Subcategory()
        {
            DeliveryProduct = new HashSet<DeliveryProduct>();
            OpeningStock = new HashSet<OpeningStock>();
            Product = new HashSet<Product>();
            PurchaseOrderProduct = new HashSet<PurchaseOrderProduct>();
            PurchaseReceiveProduct = new HashSet<PurchaseReceiveProduct>();
            PurchaseReturnProduct = new HashSet<PurchaseReturnProduct>();
            SaleProduct = new HashSet<SaleProduct>();
            SaleReturnProduct = new HashSet<SaleReturnProduct>();
            Stock = new HashSet<Stock>();
            StockLessPurchaseReturnProduct = new HashSet<StockLessPurchaseReturnProduct>();
            StockLessSaleReturnProduct = new HashSet<StockLessSaleReturnProduct>();
            StockTransfer = new HashSet<StockTransfer>();
            SupplierCategory = new HashSet<SupplierCategory>();
            WastageStock = new HashSet<WastageStock>();
        }

        public string Id { get; set; }
        public string CategoryId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool HasMultipleType { get; set; }
        public string Type { get; set; }
        public string TypeName { get; set; }
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
        public int? MeasurementType { get; set; }

        public virtual Category Category { get; set; }
        public virtual Company Company { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual Tenant Tenant { get; set; }
        public virtual ICollection<DeliveryProduct> DeliveryProduct { get; set; }
        public virtual ICollection<OpeningStock> OpeningStock { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<PurchaseOrderProduct> PurchaseOrderProduct { get; set; }
        public virtual ICollection<PurchaseReceiveProduct> PurchaseReceiveProduct { get; set; }
        public virtual ICollection<PurchaseReturnProduct> PurchaseReturnProduct { get; set; }
        public virtual ICollection<SaleProduct> SaleProduct { get; set; }
        public virtual ICollection<SaleReturnProduct> SaleReturnProduct { get; set; }
        public virtual ICollection<Stock> Stock { get; set; }
        public virtual ICollection<StockLessPurchaseReturnProduct> StockLessPurchaseReturnProduct { get; set; }
        public virtual ICollection<StockLessSaleReturnProduct> StockLessSaleReturnProduct { get; set; }
        public virtual ICollection<StockTransfer> StockTransfer { get; set; }
        public virtual ICollection<SupplierCategory> SupplierCategory { get; set; }
        public virtual ICollection<WastageStock> WastageStock { get; set; }
    }
}
