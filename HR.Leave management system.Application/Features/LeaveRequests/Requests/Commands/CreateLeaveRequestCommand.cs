using HR.Leave_management_system.Application.DTOs.LeaveRequest;
using HR.Leave_management_system.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Leave_management_system.Application.Features.LeaveRequests.Requests.Commands
{
    public class CreateLeaveRequestCommand :IRequest<BaseCommandResponse>
    {
        public CreateLeaveRequestDto LeaveRequestDto { get; set; }
    }
}
