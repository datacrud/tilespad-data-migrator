using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class DailyAccountBalance
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public double OpeningPurchase { get; set; }
        public double ClosingPurchase { get; set; }
        public double OpeningPurchaseReturn { get; set; }
        public double ClosingPurchaseReturn { get; set; }
        public double OpeningPurchasePayable { get; set; }
        public double ClosingPurchasePayable { get; set; }
        public double OpeningSales { get; set; }
        public double ClosingSales { get; set; }
        public double OpeningSaleReturn { get; set; }
        public double ClosingSaleReturn { get; set; }
        public double OpeningSaleReceiveable { get; set; }
        public double ClosingSaleReceiveable { get; set; }
        public double OpeningDeposit { get; set; }
        public double ClosingDeposit { get; set; }
        public double OpeningExpense { get; set; }
        public double ClosingExpense { get; set; }
        public double OpeningBank { get; set; }
        public double ClosingBank { get; set; }
        public double OpeningCash { get; set; }
        public double ClosingCash { get; set; }
        public double OpeningBalance { get; set; }
        public double ClosingBalance { get; set; }
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
        public string OriginalPk { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual Tenant Tenant { get; set; }
    }
}
