using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerAddress = new HashSet<CustomerAddress>();
            DailyCustomerAccountBalance = new HashSet<DailyCustomerAccountBalance>();
            Delivery = new HashSet<Delivery>();
            Sale = new HashSet<Sale>();
            SaleReturn = new HashSet<SaleReturn>();
            StocklessSaleReturn = new HashSet<StocklessSaleReturn>();
        }

        public string Id { get; set; }
        public int Identity { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public double OpeningDue { get; set; }
        public double TotalPayable { get; set; }
        public double TotalPaid { get; set; }
        public double TotalDue { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string BranchId { get; set; }
        public double ActualDue { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? Deleted { get; set; }
        public string DeletedBy { get; set; }
        public string TenantId { get; set; }
        public string CompanyId { get; set; }
        public string DeviceInfo { get; set; }
        public string IpAddress { get; set; }
        public int? Order { get; set; }
        public string OriginalPk { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual Tenant Tenant { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddress { get; set; }
        public virtual ICollection<DailyCustomerAccountBalance> DailyCustomerAccountBalance { get; set; }
        public virtual ICollection<Delivery> Delivery { get; set; }
        public virtual ICollection<Sale> Sale { get; set; }
        public virtual ICollection<SaleReturn> SaleReturn { get; set; }
        public virtual ICollection<StocklessSaleReturn> StocklessSaleReturn { get; set; }
    }
}
