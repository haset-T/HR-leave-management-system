using HR.Leave_management_system.Application.DTOs.LeaveAllocation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Leave_management_system.Application.Features.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationList_Request :IRequest<List<LeaveAllocationDto>>
    {
    }
}
