using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class StockTransferOrder
    {
        public StockTransferOrder()
        {
            StockTransferOrderProduct = new HashSet<StockTransferOrderProduct>();
            StockTransferReceive = new HashSet<StockTransferReceive>();
        }

        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string InvoiceNumber { get; set; }
        public string SourceWarehouseId { get; set; }
        public string DestinationWarehouseId { get; set; }
        public string EmployeeId { get; set; }
        public string TransferCarrierId { get; set; }
        public int TotalBox { get; set; }
        public int TotalQuantity { get; set; }
        public double TotalValue { get; set; }
        public double CarryingCharge { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public DateTime? ApproxTransferDepartureDate { get; set; }
        public DateTime? ApproxTransferArrivalDate { get; set; }
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
        public virtual Employee Employee { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual Warehouse SourceWarehouse { get; set; }
        public virtual Tenant Tenant { get; set; }
        public virtual TransferCarrier TransferCarrier { get; set; }
        public virtual ICollection<StockTransferOrderProduct> StockTransferOrderProduct { get; set; }
        public virtual ICollection<StockTransferReceive> StockTransferReceive { get; set; }
    }
}
