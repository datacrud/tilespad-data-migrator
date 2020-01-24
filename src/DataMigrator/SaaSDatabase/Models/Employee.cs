using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
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
            Sale = new HashSet<Sale>();
            SaleCommissionSetup = new HashSet<SaleCommissionSetup>();
            SaleReturn = new HashSet<SaleReturn>();
            StockTransferOrder = new HashSet<StockTransferOrder>();
            StockTransferReceive = new HashSet<StockTransferReceive>();
            StocklessPurchase = new HashSet<StocklessPurchase>();
            StocklessPurchaseReturn = new HashSet<StocklessPurchaseReturn>();
            StocklessSaleReturn = new HashSet<StocklessSaleReturn>();
            TimeLog = new HashSet<TimeLog>();
            TimeSheet = new HashSet<TimeSheet>();
        }

        public string Id { get; set; }
        public int Type { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string BloodGroup { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
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
        public string Code { get; set; }
        public string Name { get; set; }
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
        public string Surname { get; set; }
        public int? Order { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual Tenant Tenant { get; set; }
        public virtual ICollection<Delivery> Delivery { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrder { get; set; }
        public virtual ICollection<PurchaseReceive> PurchaseReceiveEmployee { get; set; }
        public virtual ICollection<PurchaseReceive> PurchaseReceiveOrderedEmployee { get; set; }
        public virtual ICollection<PurchaseReturn> PurchaseReturn { get; set; }
        public virtual ICollection<Sale> Sale { get; set; }
        public virtual ICollection<SaleCommissionSetup> SaleCommissionSetup { get; set; }
        public virtual ICollection<SaleReturn> SaleReturn { get; set; }
        public virtual ICollection<StockTransferOrder> StockTransferOrder { get; set; }
        public virtual ICollection<StockTransferReceive> StockTransferReceive { get; set; }
        public virtual ICollection<StocklessPurchase> StocklessPurchase { get; set; }
        public virtual ICollection<StocklessPurchaseReturn> StocklessPurchaseReturn { get; set; }
        public virtual ICollection<StocklessSaleReturn> StocklessSaleReturn { get; set; }
        public virtual ICollection<TimeLog> TimeLog { get; set; }
        public virtual ICollection<TimeSheet> TimeSheet { get; set; }
    }
}
