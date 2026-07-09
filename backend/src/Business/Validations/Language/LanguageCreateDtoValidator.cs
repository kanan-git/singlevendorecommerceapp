using FluentValidation;
using Entities.DTOs.Language;
using Core.Utilities.Constants;

namespace Business.Validations.Language;

public class LanguageCreateDtoValidator : AbstractValidator<LanguageCreateDto>
{
    public LanguageCreateDtoValidator()
    {
        // RuleFor(p => p.)
        //     .
    }
}
