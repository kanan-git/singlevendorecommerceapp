using FluentValidation;
using Entities.DTOs.Address;
using Core.Utilities.Constants;

namespace Business.Validations.Address;

public class AddressUpdateDtoValidator : AbstractValidator<AddressUpdateDto>
{
    public AddressUpdateDtoValidator()
    {
        // RuleFor(p => p.)
        //     .
    }
}
