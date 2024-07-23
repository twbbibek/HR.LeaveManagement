using HR.Leavemanagement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Leavemanagement.Application.DTOs.LeaveType
{
    public class CreateLeaveTypeDto
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
