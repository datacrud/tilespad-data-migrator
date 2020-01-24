using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class Expense
    {
        public Expense()
        {
            ExpenseDetail = new HashSet<ExpenseDetail>();
        }

        public string Id { get; set; }
        public int Identity { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime Date { get; set; }
        public string ExpenseHeadId { get; set; }
        public string SupplierId { get; set; }
        public double SupplierReceiveable { get; set; }
        public string Note { get; set; }
        public double TotalExpenseAmount { get; set; }
        public double TotalDiscountAmount { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool Active { get; set; }
        public string EmployeeId { get; set; }
        public double EmployeeMonthlyGrossSalary { get; set; }
        public string WarehouseId { get; set; }
        public string ProductId { get; set; }
        public int WestageQuantity { get; set; }
        public double WestageSquarefit { get; set; }
        public double WestageAmount { get; set; }
        public double TotalDueAmount { get; set; }
        public string CustomerId { get; set; }
        public double CustomerOverpayment { get; set; }
        public string BranchId { get; set; }
        public string PartnerId { get; set; }

        public virtual ExpenseHead ExpenseHead { get; set; }
        public virtual ICollection<ExpenseDetail> ExpenseDetail { get; set; }
    }
}
