using FluentValidation;
using Entities.DTOs.MediaFile;
using Core.Utilities.Constants;

namespace Business.Validations.MediaFile;

public class MediaFileUpdateDtoValidator : AbstractValidator<MediaFileUpdateDto>
{
    public MediaFileUpdateDtoValidator()
    {
        // RuleFor(p => p.)
        //     .
    }
}
