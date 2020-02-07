using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class Warehouse
    {
        public Warehouse()
        {
            Branch = new HashSet<Branch>();
            DeliveryProduct = new HashSet<DeliveryProduct>();
            OpeningStock = new HashSet<OpeningStock>();
            PurchaseReceiveProduct = new HashSet<PurchaseReceiveProduct>();
            PurchaseReturnProduct = new HashSet<PurchaseReturnProduct>();
            SaleReturnProduct = new HashSet<SaleReturnProduct>();
            Stock = new HashSet<Stock>();
            StockLessPurchaseReturnProduct = new HashSet<StockLessPurchaseReturnProduct>();
            StockLessSaleReturnProduct = new HashSet<StockLessSaleReturnProduct>();
            StockTransferDestinationWarehouse = new HashSet<StockTransfer>();
            StockTransferOrderDestinationWarehouse = new HashSet<StockTransferOrder>();
            StockTransferOrderSourceWarehouse = new HashSet<StockTransferOrder>();
            StockTransferReceiveDestinationWarehouse = new HashSet<StockTransferReceive>();
            StockTransferReceiveProductDestinationWarehouse = new HashSet<StockTransferReceiveProduct>();
            StockTransferReceiveProductSourceWarehouse = new HashSet<StockTransferReceiveProduct>();
            StockTransferReceiveSourceWarehouse = new HashSet<StockTransferReceive>();
            StockTransferSourceWarehouse = new HashSet<StockTransfer>();
            WastageStock = new HashSet<WastageStock>();
        }

        public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Type { get; set; }
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
        public string OriginalPk { get; set; }

        public virtual Company Company { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual Tenant Tenant { get; set; }
        public virtual ICollection<Branch> Branch { get; set; }
        public virtual ICollection<DeliveryProduct> DeliveryProduct { get; set; }
        public virtual ICollection<OpeningStock> OpeningStock { get; set; }
        public virtual ICollection<PurchaseReceiveProduct> PurchaseReceiveProduct { get; set; }
        public virtual ICollection<PurchaseReturnProduct> PurchaseReturnProduct { get; set; }
        public virtual ICollection<SaleReturnProduct> SaleReturnProduct { get; set; }
        public virtual ICollection<Stock> Stock { get; set; }
        public virtual ICollection<StockLessPurchaseReturnProduct> StockLessPurchaseReturnProduct { get; set; }
        public virtual ICollection<StockLessSaleReturnProduct> StockLessSaleReturnProduct { get; set; }
        public virtual ICollection<StockTransfer> StockTransferDestinationWarehouse { get; set; }
        public virtual ICollection<StockTransferOrder> StockTransferOrderDestinationWarehouse { get; set; }
        public virtual ICollection<StockTransferOrder> StockTransferOrderSourceWarehouse { get; set; }
        public virtual ICollection<StockTransferReceive> StockTransferReceiveDestinationWarehouse { get; set; }
        public virtual ICollection<StockTransferReceiveProduct> StockTransferReceiveProductDestinationWarehouse { get; set; }
        public virtual ICollection<StockTransferReceiveProduct> StockTransferReceiveProductSourceWarehouse { get; set; }
        public virtual ICollection<StockTransferReceive> StockTransferReceiveSourceWarehouse { get; set; }
        public virtual ICollection<StockTransfer> StockTransferSourceWarehouse { get; set; }
        public virtual ICollection<WastageStock> WastageStock { get; set; }
    }
}
