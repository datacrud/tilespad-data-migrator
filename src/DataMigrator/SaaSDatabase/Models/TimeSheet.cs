using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class TimeSheet
    {
        public TimeSheet()
        {
            TimeLog = new HashSet<TimeLog>();
        }

        public string Id { get; set; }
        public string EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public int? ClockType { get; set; }
        public int ClockStatus { get; set; }
        public string Note { get; set; }
        public string BranchId { get; set; }
        public string CompanyId { get; set; }
        public string TenantId { get; set; }
        public bool Active { get; set; }
        public int? Order { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? Deleted { get; set; }
        public string DeletedBy { get; set; }
        public string DeviceInfo { get; set; }
        public string IpAddress { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual Tenant Tenant { get; set; }
        public virtual ICollection<TimeLog> TimeLog { get; set; }
    }
}
