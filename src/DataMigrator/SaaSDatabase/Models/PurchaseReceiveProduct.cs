using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class PurchaseReceiveProduct
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string PurchaseReceiveId { get; set; }
        public string PurchaseOrderId { get; set; }
        public string WarehouseId { get; set; }
        public string CategoryId { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string TruckNumber { get; set; }
        public string Note { get; set; }
        public int Box { get; set; }
        public int Quantity { get; set; }
        public double Squarefit { get; set; }
        public int OrderedBox { get; set; }
        public int OrderedQuantity { get; set; }
        public double OrderedSquarefit { get; set; }
        public int OrderedDueBox { get; set; }
        public int OrderedDueQuantity { get; set; }
        public double OrderedDueSquarefit { get; set; }
        public double ActualSquarefit { get; set; }
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
        public int DeliveredBox { get; set; }
        public int DeliveredQuantity { get; set; }
        public double DeliveredSquarefit { get; set; }
        public int SoldBox { get; set; }
        public int SoldQuantity { get; set; }
        public double SoldSquarefit { get; set; }
        public double Rate { get; set; }
        public double TotalValue { get; set; }
        public bool IsRateImported { get; set; }
        public bool IsSoldOut { get; set; }
        public bool IsDelivered { get; set; }
        public bool IsOfferItem { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Category Category { get; set; }
        public virtual Company Company { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual Product Product { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual PurchaseReceive PurchaseReceive { get; set; }
        public virtual Subcategory Subcategory { get; set; }
        public virtual Tenant Tenant { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
