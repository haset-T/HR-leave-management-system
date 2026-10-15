using HR.Leave_management_system.Application.DTOs.LeaveAllocation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Leave_management_system.Application.Features.LeaveAllocations.Requests.Commands
{
    public class UpdateLeaveAllocationCommand:IRequest<Unit>
    {
        public UpdateLeaveAllocationDto LeaveAllocationDto { get; set; }
    }
}
