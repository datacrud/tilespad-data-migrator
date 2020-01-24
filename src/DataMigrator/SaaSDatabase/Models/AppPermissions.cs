using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class AppPermissions
    {
        public string Id { get; set; }
        public string RoleId { get; set; }
        public string ResourceId { get; set; }
        public string TenantId { get; set; }
        public string CompanyId { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? Deleted { get; set; }
        public string DeletedBy { get; set; }
        public string DeviceInfo { get; set; }
        public string IpAddress { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual AppResources Resource { get; set; }
        public virtual AppRoles Role { get; set; }
    }
}
