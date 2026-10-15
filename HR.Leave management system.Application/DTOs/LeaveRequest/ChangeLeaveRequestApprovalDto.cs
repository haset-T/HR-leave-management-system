using HR.Leave_management_system.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Leave_management_system.Application.DTOs.LeaveRequest
{
    public class ChangeLeaveRequestApprovalDto : BaseDto
    {
        public bool? Approved {  get; set; }
    }
}
