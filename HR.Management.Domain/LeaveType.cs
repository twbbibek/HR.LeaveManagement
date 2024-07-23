using HR.Management.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Management.Domain
{
    public class LeaveType : BaseDomainEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
