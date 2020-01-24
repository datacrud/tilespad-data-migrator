using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class EmailLog
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string EmailSenderUserId { get; set; }
        public string FromEmailAddress { get; set; }
        public string ToEmailAddress { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int EmailType { get; set; }
        public bool IsRead { get; set; }
        public bool IsUsedCarryForwardEmail { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? Deleted { get; set; }
        public string DeletedBy { get; set; }
        public string TenantId { get; set; }
        public string CompanyId { get; set; }
        public string BranchId { get; set; }
        public string DeviceInfo { get; set; }
        public string IpAddress { get; set; }
        public string EntityId { get; set; }
        public string EntityInvoiceNo { get; set; }
        public int EntityType { get; set; }
        public int ActionType { get; set; }
        public int? Order { get; set; }
        public string EmailReceiverUserId { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual Tenant Tenant { get; set; }
    }
}
