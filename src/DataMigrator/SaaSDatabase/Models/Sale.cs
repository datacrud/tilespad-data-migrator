using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
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
        public string OrderNumber { get; set; }
        public DateTime Date { get; set; }
        public string CustomerId { get; set; }
        public string Phone { get; set; }
        public string ContactAddress { get; set; }
        public string Note { get; set; }
        public double Subtotal { get; set; }
        public double Discount { get; set; }
        public double Tax { get; set; }
        public double TaxAmount { get; set; }
        public double NetPrice { get; set; }
        public double PreviousDue { get; set; }
        public double Total { get; set; }
        public double TotalPaid { get; set; }
        public double TotalDue { get; set; }
        public double SaleDue { get; set; }
        public int TotalBox { get; set; }
        public int TotalQuantity { get; set; }
        public double TotalSquarefit { get; set; }
        public int Status { get; set; }
        public bool IsMarkResolved { get; set; }
        public double LabourCharge { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string BranchId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? Deleted { get; set; }
        public string DeletedBy { get; set; }
        public string TenantId { get; set; }
        public string CompanyId { get; set; }
        public string DeviceInfo { get; set; }
        public string IpAddress { get; set; }
        public int? Order { get; set; }
        public string SaleReferenceId { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual Employee SaleReference { get; set; }
        public virtual Tenant Tenant { get; set; }
        public virtual ICollection<Delivery> Delivery { get; set; }
        public virtual ICollection<DeliveryProduct> DeliveryProduct { get; set; }
        public virtual ICollection<SalePayment> SalePayment { get; set; }
        public virtual ICollection<SaleProduct> SaleProduct { get; set; }
    }
}
