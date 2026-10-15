using HR.Leave_management_system.Application.DTOs.Common;
using HR.Leave_management_system.Application.DTOs.LeaveType;
using HR.Leave_management_system.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Leave_management_system.Application.DTOs.LeaveAllocation
{
    public class LeaveAllocationDto : BaseDto
    {
        public int NumberOfDays { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
