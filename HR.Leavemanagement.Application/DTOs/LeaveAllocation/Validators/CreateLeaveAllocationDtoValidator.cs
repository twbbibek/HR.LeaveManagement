using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.Leavemanagement.Application.DTOs.LeaveAllocation.Validators
{
    public class CreateLeaveAllocationDtoValidator : AbstractValidator<CreateLeaveAllocationDto>
    {
        public CreateLeaveAllocationDtoValidator()
        {

            RuleFor(p => p.NumberOfDays)
              .NotEmpty().WithMessage("{PropertyName} is required")
              .NotNull();

            RuleFor(p => p.LeaveTypeId)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .GreaterThan(0);

            RuleFor(p => p.Period)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .GreaterThan(0);
        }
    }
}
