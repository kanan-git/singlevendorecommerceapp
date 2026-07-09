using FluentValidation;
using Entities.DTOs.Address;
using Core.Utilities.Constants;

namespace Business.Validations.Address;

public class AddressCreateDtoValidator : AbstractValidator<AddressCreateDto>
{
    public AddressCreateDtoValidator()
    {
        // RuleFor(p => p.)
        //     .
    }
}
