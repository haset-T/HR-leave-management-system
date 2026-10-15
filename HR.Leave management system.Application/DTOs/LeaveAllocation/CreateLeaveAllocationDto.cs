using HR.Leave_management_system.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Leave_management_system.Application.DTOs.LeaveAllocation
{
    public class CreateLeaveAllocationDto : BaseDto , ILeaveAllocationDto
    {
        public int NumberOfDays { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period {  get; set; }
    }
}
