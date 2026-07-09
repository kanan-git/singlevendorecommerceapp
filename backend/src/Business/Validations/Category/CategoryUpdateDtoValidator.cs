using FluentValidation;
using Entities.DTOs.Category;
using Core.Utilities.Constants;

namespace Business.Validations.Category;

public class CategoryUpdateDtoValidator : AbstractValidator<CategoryUpdateDto>
{
    public CategoryUpdateDtoValidator()
    {
        // RuleFor(p => p.)
        //     .
    }
}
