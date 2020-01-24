using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class Deposit
    {
        public Deposit()
        {
            DepositDetail = new HashSet<DepositDetail>();
        }

        public string Id { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime Date { get; set; }
        public string DepositHeadId { get; set; }
        public string CustomerId { get; set; }
        public string SaleId { get; set; }
        public string SaleDue { get; set; }
        public double CustomerPayable { get; set; }
        public string SupplierId { get; set; }
        public double SupplierReceiveable { get; set; }
        public string Note { get; set; }
        public double TotalAmount { get; set; }
        public double TotalDiscountAmount { get; set; }
        public double TotalDueAmount { get; set; }
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
        public string ParentHeadId { get; set; }
        public string EntityId { get; set; }
        public int? EntityName { get; set; }
        public double? EntityNotableAmount { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual DepositHead DepositHead { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual DepositHead ParentHead { get; set; }
        public virtual Tenant Tenant { get; set; }
        public virtual ICollection<DepositDetail> DepositDetail { get; set; }
    }
}
