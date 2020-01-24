using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class Feature
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int ValueType { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsFeature { get; set; }
        public bool IsEditionFeature { get; set; }
        public bool IsTenantFeature { get; set; }
        public string EditionId { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? Deleted { get; set; }
        public string DeletedBy { get; set; }
        public bool IsStatic { get; set; }
        public int? Order { get; set; }
        public string DeviceInfo { get; set; }
        public string IpAddress { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual Edition Edition { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
    }
}
