using System;
using System.Collections.Generic;

namespace StandaloneDatabase.Models
{
    public partial class LoginAttempt
    {
        public string Id { get; set; }
        public DateTime? Date { get; set; }
        public string Username { get; set; }
        public int Status { get; set; }
        public string Reason { get; set; }
        public string IpAddress { get; set; }
        public string DeviceInfo { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string BranchId { get; set; }
    }
}
