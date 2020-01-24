using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class Deposit
    {
        public Deposit()
        {
            DepositDetail = new HashSet<DepositDetail>();
        }

        public string Id { get; set; }
        public int Identity { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime Date { get; set; }
        public string DepositHeadId { get; set; }
        public string CustomerId { get; set; }
        public double CustomerPayable { get; set; }
        public string Note { get; set; }
        public double TotalDepositAmount { get; set; }
        public double TotalDiscountAmount { get; set; }
        public double TotalRemainingAmount { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool Active { get; set; }
        public string SaleId { get; set; }
        public string SaleDue { get; set; }
        public string SupplierId { get; set; }
        public double SupplierReceiveable { get; set; }
        public string BranchId { get; set; }
        public string PartnerId { get; set; }

        public virtual DepositHead DepositHead { get; set; }
        public virtual ICollection<DepositDetail> DepositDetail { get; set; }
    }
}
