using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class SalePayment
    {
        public string Id { get; set; }
        public string SaleId { get; set; }
        public int PaymentMethod { get; set; }
        public string BankId { get; set; }
        public string BankCheckId { get; set; }
        public double Paid { get; set; }
        public double Due { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool Active { get; set; }
        public DateTime Date { get; set; }
        public string BranchId { get; set; }

        public virtual Sale Sale { get; set; }
    }
}
