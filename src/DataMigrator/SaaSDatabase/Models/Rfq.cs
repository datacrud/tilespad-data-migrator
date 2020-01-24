using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class Rfq
    {
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string YourName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public int TotalUsers { get; set; }
        public int TotalBranch { get; set; }
        public int TotalMonthlyEmailNotfication { get; set; }
        public string HowYouKnowAboutUs { get; set; }
        public string HowYouKnowAboutUsMessage { get; set; }
        public string Comment { get; set; }
        public string ResponseMessage { get; set; }
        public int RfqStatus { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? Deleted { get; set; }
        public string DeletedBy { get; set; }
        public string WhatIneed { get; set; }
        public string DeviceInfo { get; set; }
        public string IpAddress { get; set; }
        public int? Order { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
    }
}
