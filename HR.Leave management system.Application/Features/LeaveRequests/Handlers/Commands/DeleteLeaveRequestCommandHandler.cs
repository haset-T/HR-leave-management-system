using AutoMapper;
using HR.Leave_management_system.Application.Execeptions;
using HR.Leave_management_system.Application.Features.LeaveRequests.Requests.Commands;
using HR.Leave_management_system.Application.Contracts.Persistence;
using HR.Leave_management_system.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HR.Leave_management_system.Application.Features.LeaveRequests.Handlers.Commands
{
    public class DeleteLeaveRequestCommandHandler : IRequestHandler<DeleteLeaveRequestCommand>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private IMapper _mapper;

        public DeleteLeaveRequestCommandHandler (ILeaveRequestRepository leaveRequestRepository , IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;   
        }

        public async Task<Unit> Handle(DeleteLeaveRequestCommand request, CancellationToken cancellationToken)
        {

          
            var leaveRequest = await _leaveRequestRepository.Get(request.Id);

            if (leaveRequest == null)
            {
                throw new NotFoundException(nameof(LeaveRequest), request.Id);
            }
            await _leaveRequestRepository.Delete(leaveRequest);

            return Unit.Value;
        }
    }
}
