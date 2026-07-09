using FluentValidation;
using Entities.DTOs.Brand;
using Core.Utilities.Constants;

namespace Business.Validations.Brand;

public class BrandCreateDtoValidator : AbstractValidator<BrandCreateDto>
{
    public BrandCreateDtoValidator()
    {
        // RuleFor(p => p.)
        //     .
    }
}
