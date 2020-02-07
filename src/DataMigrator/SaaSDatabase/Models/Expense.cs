using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class Expense
    {
        public Expense()
        {
            ExpenseDetail = new HashSet<ExpenseDetail>();
        }

        public string Id { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime Date { get; set; }
        public string ExpenseHeadId { get; set; }
        public string SupplierId { get; set; }
        public double SupplierReceiveable { get; set; }
        public string EmployeeId { get; set; }
        public double EmployeeMonthlyGrossSalary { get; set; }
        public string WarehouseId { get; set; }
        public string ProductId { get; set; }
        public int WestageQuantity { get; set; }
        public double WestageSquarefit { get; set; }
        public double WestageAmount { get; set; }
        public string CustomerId { get; set; }
        public double CustomerOverpayment { get; set; }
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
        public string OriginalPk { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual ExpenseHead ExpenseHead { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual ExpenseHead ParentHead { get; set; }
        public virtual Tenant Tenant { get; set; }
        public virtual ICollection<ExpenseDetail> ExpenseDetail { get; set; }
    }
}
