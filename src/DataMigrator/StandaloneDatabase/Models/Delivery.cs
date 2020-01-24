using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class Delivery
    {
        public Delivery()
        {
            DeliveryProduct = new HashSet<DeliveryProduct>();
        }

        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string CustomerId { get; set; }
        public string SaleId { get; set; }
        public string CustomerPhone { get; set; }
        public int Status { get; set; }
        public int TotalQuantity { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool Active { get; set; }
        public int Identity { get; set; }
        public string DeliveryNumber { get; set; }
        public string EmployeeId { get; set; }
        public double TotalSquarefit { get; set; }
        public int TotalBox { get; set; }
        public string BranchId { get; set; }
        public string Note { get; set; }
        public double TotalSaleDeliveredPrice { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Sale Sale { get; set; }
        public virtual ICollection<DeliveryProduct> DeliveryProduct { get; set; }
    }
}
