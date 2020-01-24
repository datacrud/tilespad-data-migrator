using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class AspNetRoles
    {
        public AspNetRoles()
        {
            AspNetPermission = new HashSet<AspNetPermission>();
            AspNetUserRoles = new HashSet<AspNetUserRoles>();
        }

        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AspNetPermission> AspNetPermission { get; set; }
        public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
    }
}
