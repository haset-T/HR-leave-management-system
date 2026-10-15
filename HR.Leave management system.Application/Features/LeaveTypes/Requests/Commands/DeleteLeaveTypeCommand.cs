using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Leave_management_system.Application.Features.LeaveTypes.Requests.Commands
{
    public class DeleteLeaveType_Command: IRequest 
    {
        public int Id { get; set; }
    }
}
