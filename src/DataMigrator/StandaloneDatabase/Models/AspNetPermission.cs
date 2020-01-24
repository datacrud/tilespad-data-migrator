using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class AspNetPermission
    {
        public string Id { get; set; }
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string ResourceId { get; set; }

        public virtual AspNetResource Resource { get; set; }
        public virtual AspNetRoles Role { get; set; }
    }
}
