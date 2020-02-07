using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class AppResources
    {
        public AppResources()
        {
            AppPermissions = new HashSet<AppPermissions>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Route { get; set; }
        public string ParentRoute { get; set; }
        public bool IsPublic { get; set; }
        public int? Order { get; set; }
        public int ResourceOwner { get; set; }
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
        public string OriginalPk { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual ICollection<AppPermissions> AppPermissions { get; set; }
    }
}
