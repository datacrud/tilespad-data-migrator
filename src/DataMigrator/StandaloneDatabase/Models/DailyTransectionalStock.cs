using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class DailyTransectionalStock
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public int OpeningQuantity { get; set; }
        public int ClosingQuantity { get; set; }
        public double OpeningSquarefit { get; set; }
        public double ClosingSquarefit { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public int OpeningBox { get; set; }
        public int ClosingBox { get; set; }
        public string BranchId { get; set; }
    }
}
