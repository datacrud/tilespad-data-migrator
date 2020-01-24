using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class Warehouse
    {
        public Warehouse()
        {
            DeliveryProduct = new HashSet<DeliveryProduct>();
            OpeningStock = new HashSet<OpeningStock>();
            PurchaseReceiveProduct = new HashSet<PurchaseReceiveProduct>();
            PurchaseReturnProduct = new HashSet<PurchaseReturnProduct>();
            SaleReturnProduct = new HashSet<SaleReturnProduct>();
            Stock = new HashSet<Stock>();
            StockTransferDestinationWarehouse = new HashSet<StockTransfer>();
            StockTransferSourceWarehouse = new HashSet<StockTransfer>();
            WestageStock = new HashSet<WestageStock>();
        }

        public string Id { get; set; }
        public int Identity { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Type { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool Active { get; set; }
        public string BranchId { get; set; }

        public virtual ICollection<DeliveryProduct> DeliveryProduct { get; set; }
        public virtual ICollection<OpeningStock> OpeningStock { get; set; }
        public virtual ICollection<PurchaseReceiveProduct> PurchaseReceiveProduct { get; set; }
        public virtual ICollection<PurchaseReturnProduct> PurchaseReturnProduct { get; set; }
        public virtual ICollection<SaleReturnProduct> SaleReturnProduct { get; set; }
        public virtual ICollection<Stock> Stock { get; set; }
        public virtual ICollection<StockTransfer> StockTransferDestinationWarehouse { get; set; }
        public virtual ICollection<StockTransfer> StockTransferSourceWarehouse { get; set; }
        public virtual ICollection<WestageStock> WestageStock { get; set; }
    }
}
