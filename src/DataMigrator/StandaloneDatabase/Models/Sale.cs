using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class Sale
    {
        public Sale()
        {
            Delivery = new HashSet<Delivery>();
            DeliveryProduct = new HashSet<DeliveryProduct>();
            SalePayment = new HashSet<SalePayment>();
            SaleProduct = new HashSet<SaleProduct>();
        }

        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string OrderNumber { get; set; }
        public string CustomerId { get; set; }
        public string Phone { get; set; }
        public string Note { get; set; }
        public double Subtotal { get; set; }
        public double Discount { get; set; }
        public double Tax { get; set; }
        public double TaxAmount { get; set; }
        public double NetPrice { get; set; }
        public double PreviousDue { get; set; }
        public double Total { get; set; }
        public double TotalPaid { get; set; }
        public double SaleDue { get; set; }
        public double TotalDue { get; set; }
        public int TotalQuantity { get; set; }
        public int Status { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool Active { get; set; }
        public string ContactAddress { get; set; }
        public int TotalBox { get; set; }
        public double TotalSquarefit { get; set; }
        public double LabourCharge { get; set; }
        public string BranchId { get; set; }
        public bool IsMarkResolved { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Delivery> Delivery { get; set; }
        public virtual ICollection<DeliveryProduct> DeliveryProduct { get; set; }
        public virtual ICollection<SalePayment> SalePayment { get; set; }
        public virtual ICollection<SaleProduct> SaleProduct { get; set; }
    }
}
