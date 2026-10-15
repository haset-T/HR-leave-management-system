using HR.Leave_management_system.Application.DTOs.LeaveAllocation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Leave_management_system.Application.Features.LeaveAllocations.Requests.Commands
{
    public class CreateLeaveAllocationCommand :IRequest<int>
    {
        public CreateLeaveAllocationDto LeaveAllocation { get; set; }
    }
}
