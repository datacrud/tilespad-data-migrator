using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class ComissionSetup
    {
        public string Id { get; set; }
        public string SupplierId { get; set; }
        public bool IsCategoryDependentComission { get; set; }
        public string CategoryId { get; set; }
        public bool HasMonthlyComission { get; set; }
        public double MonthlyRangeFrom { get; set; }
        public double MonthlyRangeTill { get; set; }
        public bool HasQuarterComission { get; set; }
        public double QuarterRangeFrom { get; set; }
        public double QuarterRangeTill { get; set; }
        public bool HasYearlyComission { get; set; }
        public double YearlyRangeFrom { get; set; }
        public double YearlyRangeTill { get; set; }
        public double ComissionRate { get; set; }
        public bool HasYearlyPoint { get; set; }
        public double YearlyPoint { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string BranchId { get; set; }
        public double MonthlyComissionRate { get; set; }
        public double QuarterComissionRate { get; set; }
        public double YearlyComissionRate { get; set; }
        public bool HasGeneralComission { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
