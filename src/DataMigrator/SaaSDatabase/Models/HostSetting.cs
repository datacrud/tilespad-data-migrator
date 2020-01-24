using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class HostSetting
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int ValueType { get; set; }
        public bool IsStatic { get; set; }
    }
}
