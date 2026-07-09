using FluentValidation;
using Entities.DTOs.MediaFile;
using Core.Utilities.Constants;

namespace Business.Validations.MediaFile;

public class MediaFileCreateDtoValidator : AbstractValidator<MediaFileCreateDto>
{
    public MediaFileCreateDtoValidator()
    {
        // RuleFor(p => p.)
        //     .
    }
}
