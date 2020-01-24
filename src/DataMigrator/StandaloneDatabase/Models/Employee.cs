using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Delivery = new HashSet<Delivery>();
            PurchaseOrder = new HashSet<PurchaseOrder>();
            PurchaseReceiveEmployee = new HashSet<PurchaseReceive>();
            PurchaseReceiveOrderedEmployee = new HashSet<PurchaseReceive>();
            PurchaseReturn = new HashSet<PurchaseReturn>();
            SaleReturn = new HashSet<SaleReturn>();
        }

        public string Id { get; set; }
        public int Type { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string BloodGroup { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nid { get; set; }
        public string Image { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhone { get; set; }
        public string EmergencyContactRelation { get; set; }
        public string Note { get; set; }
        public double BasicSalary { get; set; }
        public double MonthlyGrossSalary { get; set; }
        public double YearlyGrossSalary { get; set; }
        public int Identity { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool Active { get; set; }
        public string BranchId { get; set; }

        public virtual ICollection<Delivery> Delivery { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrder { get; set; }
        public virtual ICollection<PurchaseReceive> PurchaseReceiveEmployee { get; set; }
        public virtual ICollection<PurchaseReceive> PurchaseReceiveOrderedEmployee { get; set; }
        public virtual ICollection<PurchaseReturn> PurchaseReturn { get; set; }
        public virtual ICollection<SaleReturn> SaleReturn { get; set; }
    }
}
