using FluentValidation;
using HR.Leave_management_system.Application.Persistence.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Leave_management_system.Application.DTOs.LeaveRequest.Validators
{
    public class CreateLeaveRequestDtoValidator :AbstractValidator<CreateLeaveRequestDto>
    {

        private readonly ILeaveTypeRepository _leaveTypeRepository;
        public CreateLeaveRequestDtoValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;

            Include(new ILeaveRequestDtoValidator(_leaveTypeRepository));
        }
    }
}
    