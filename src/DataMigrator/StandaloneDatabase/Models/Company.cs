using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class Company
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Web { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string Moto { get; set; }
        public string Description { get; set; }
        public byte[] Logo { get; set; }
        public string LogoName { get; set; }
        public string LogoPath { get; set; }
        public string PoweredBy { get; set; }
        public DateTime FiscalYearStartDate { get; set; }
        public DateTime FiscalYearEndDate { get; set; }
        public string BranchId { get; set; }
        public DateTime? HostingValidTill { get; set; }
        public string SaleReturnCondition { get; set; }
        public bool EnableRoundSaleSquarefit { get; set; }
        public double? VatPercentage { get; set; }
        public string TinNumber { get; set; }
    }
}
