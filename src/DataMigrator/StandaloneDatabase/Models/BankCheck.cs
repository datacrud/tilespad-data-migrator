using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class BankCheck
    {
        public string Id { get; set; }
        public int TransectionType { get; set; }
        public string TransectionId { get; set; }
        public int PayerType { get; set; }
        public string PayerId { get; set; }
        public DateTime CheckDate { get; set; }
        public string BankName { get; set; }
        public string CheckNumber { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public double TotalAmount { get; set; }
        public string IssuedBy { get; set; }
        public DateTime DueDate { get; set; }
        public string Note { get; set; }
        public int CheckOwner { get; set; }
        public int CheckStatus { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool Active { get; set; }
        public string BranchId { get; set; }
    }
}
