using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class AspNetResource
    {
        public AspNetResource()
        {
            AspNetPermission = new HashSet<AspNetPermission>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Route { get; set; }
        public bool IsPublic { get; set; }

        public virtual ICollection<AspNetPermission> AspNetPermission { get; set; }
    }
}
