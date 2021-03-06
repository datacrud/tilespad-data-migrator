﻿using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class DepositHead
    {
        public DepositHead()
        {
            DepositDepositHead = new HashSet<Deposit>();
            DepositParentHead = new HashSet<Deposit>();
            InverseParent = new HashSet<DepositHead>();
        }

        public string Id { get; set; }
        public int Identity { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? HeadType { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string BranchId { get; set; }
        public string DisplayName { get; set; }
        public bool IsStatic { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? Deleted { get; set; }
        public string DeletedBy { get; set; }
        public string TenantId { get; set; }
        public string CompanyId { get; set; }
        public string DeviceInfo { get; set; }
        public string IpAddress { get; set; }
        public int? Order { get; set; }
        public string ParentId { get; set; }
        public bool IsSystemHead { get; set; }
        public bool IsAllowed { get; set; }
        public string OriginalPk { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual DepositHead Parent { get; set; }
        public virtual Tenant Tenant { get; set; }
        public virtual ICollection<Deposit> DepositDepositHead { get; set; }
        public virtual ICollection<Deposit> DepositParentHead { get; set; }
        public virtual ICollection<DepositHead> InverseParent { get; set; }
    }
}
