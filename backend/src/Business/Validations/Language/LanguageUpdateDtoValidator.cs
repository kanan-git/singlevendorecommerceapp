using FluentValidation;
using Entities.DTOs.Language;
using Core.Utilities.Constants;

namespace Business.Validations.Language;

public class LanguageUpdateDtoValidator : AbstractValidator<LanguageUpdateDto>
{
    public LanguageUpdateDtoValidator()
    {
        // RuleFor(p => p.)
        //     .
    }
}
