using HR.Leave_management_system.Application.DTOs.LeaveType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Leave_management_system.Application.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypeCommand :IRequest<int>
    {
       public CreateLeaveTypeDto LeaveTypeDto { get; set; }
    }
}
