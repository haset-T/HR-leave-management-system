using HR.Leave_management_system.Application.DTOs.Common;
using HR.Leave_management_system.Application.DTOs.LeaveType;
using HR.Leave_management_system.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Leave_management_system.Application.DTOs.LeaveRequest
{
    public class LeaveRequestDto: BaseDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public string RequestComments { get; set; }
        public DateTime? DateActioned { get; set; }
        public bool? Approved { get; set; }
        public bool cancelled { get; set; }
    }
}
