using FluentValidation;
using Entities.DTOs.Category;
using Core.Utilities.Constants;

namespace Business.Validations.Category;

public class CategoryCreateDtoValidator : AbstractValidator<CategoryCreateDto>
{
    public CategoryCreateDtoValidator()
    {
        // RuleFor(p => p.)
        //     .
    }
}
