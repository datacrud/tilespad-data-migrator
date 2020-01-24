using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class Scheduler
    {
        public string Id { get; set; }
        public int SchedulerType { get; set; }
        public DateTime NextRunTime { get; set; }
        public DateTime LastRunTime { get; set; }
        public bool EnableScheduler { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string BranchId { get; set; }
    }
}
