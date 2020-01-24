using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class DailyTransectionalBalance
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public double OpeningPurchase { get; set; }
        public double ClosingPurchase { get; set; }
        public double OpeningSales { get; set; }
        public double ClosingSales { get; set; }
        public double OpeningDeposit { get; set; }
        public double ClosingDeposit { get; set; }
        public double OpeningExpense { get; set; }
        public double ClosingExpense { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public double OpeningPurchaseReturn { get; set; }
        public double ClosingPurchaseReturn { get; set; }
        public double OpeningPurchasePayable { get; set; }
        public double ClosingPurchasePayable { get; set; }
        public double OpeningSaleReturn { get; set; }
        public double ClosingSaleReturn { get; set; }
        public double OpeningSaleReceiveable { get; set; }
        public double ClosingSaleReceiveable { get; set; }
        public double OpeningBalance { get; set; }
        public double ClosingBalance { get; set; }
        public double OpeningBank { get; set; }
        public double ClosingBank { get; set; }
        public double OpeningCash { get; set; }
        public double ClosingCash { get; set; }
        public string BranchId { get; set; }
    }
}
