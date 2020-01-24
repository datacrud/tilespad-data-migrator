using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class StockTransferReceiveProduct
    {
        public string Id { get; set; }
        public string StockTransferReceiveId { get; set; }
        public string SourceWarehouseId { get; set; }
        public string DestinationWarehouseId { get; set; }
        public DateTime Date { get; set; }
        public string ProductId { get; set; }
        public int TransferBox { get; set; }
        public int TransferQuantity { get; set; }
        public double TransferValue { get; set; }
        public string BranchId { get; set; }
        public string CompanyId { get; set; }
        public string TenantId { get; set; }
        public bool Active { get; set; }
        public int? Order { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? Deleted { get; set; }
        public string DeletedBy { get; set; }
        public string DeviceInfo { get; set; }
        public string IpAddress { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual Warehouse DestinationWarehouse { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual Product Product { get; set; }
        public virtual Warehouse SourceWarehouse { get; set; }
        public virtual StockTransferReceive StockTransferReceive { get; set; }
        public virtual Tenant Tenant { get; set; }
    }
}
