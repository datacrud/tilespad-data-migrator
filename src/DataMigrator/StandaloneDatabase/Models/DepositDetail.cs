using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class DepositDetail
    {
        public string Id { get; set; }
        public string DepositId { get; set; }
        public int PaymentMethod { get; set; }
        public string BankCheckId { get; set; }
        public string BankId { get; set; }
        public double TotalAmount { get; set; }
        public double DiscountAmount { get; set; }
        public double RemainingAmount { get; set; }
        public string Note { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool Active { get; set; }
        public DateTime Date { get; set; }
        public string BranchId { get; set; }

        public virtual Deposit Deposit { get; set; }
    }
}
