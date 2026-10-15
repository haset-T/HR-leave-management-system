using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Leave_management_system.Application.DTOs.LeaveType.Validators
{
    public class UpdateLeaveTypeDtoValidator : AbstractValidator<LeaveTypeDto>
    {
        public UpdateLeaveTypeDtoValidator()
        {
            Include (new ILeaveTypeDtoValidator());
            RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} must be presented");
        }
    }
}
