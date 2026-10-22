using AutoMapper;
using HR.Leave_management_system.Application.Execeptions;
using HR.Leave_management_system.Application.Features.LeaveTypes.Requests.Commands;
using HR.Leave_management_system.Application.Contracts.Persistence;
using HR.Leave_management_system.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HR.Leave_management_system.Application.Features.LeaveTypes.Handlers.Commands
{
    public class DeleteLeaveTypeCommandHandler : IRequestHandler<DeleteLeaveType_Command>
    {

        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public DeleteLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteLeaveType_Command request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.Get(request.Id);

            if (leaveType == null)
            {
                throw new NotFoundException(nameof(LeaveType),request.Id);
            }

            await _leaveTypeRepository.Delete(leaveType);

            return Unit.Value;
        }
    }
}
