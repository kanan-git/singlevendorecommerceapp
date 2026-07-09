using FluentValidation;
using Entities.DTOs.Brand;
using Core.Utilities.Constants;

namespace Business.Validations.Brand;

public class BrandUpdateDtoValidator : AbstractValidator<BrandUpdateDto>
{
    public BrandUpdateDtoValidator()
    {
        // RuleFor(p => p.)
        //     .
    }
}
