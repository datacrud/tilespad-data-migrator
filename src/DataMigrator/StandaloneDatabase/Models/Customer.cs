using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerAddress = new HashSet<CustomerAddress>();
            DailyCustomerTransectionalBalance = new HashSet<DailyCustomerTransectionalBalance>();
            Delivery = new HashSet<Delivery>();
            Sale = new HashSet<Sale>();
            SaleReturn = new HashSet<SaleReturn>();
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
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool Active { get; set; }
        public string BranchId { get; set; }
        public double ActualDue { get; set; }

        public virtual ICollection<CustomerAddress> CustomerAddress { get; set; }
        public virtual ICollection<DailyCustomerTransectionalBalance> DailyCustomerTransectionalBalance { get; set; }
        public virtual ICollection<Delivery> Delivery { get; set; }
        public virtual ICollection<Sale> Sale { get; set; }
        public virtual ICollection<SaleReturn> SaleReturn { get; set; }
    }
}
