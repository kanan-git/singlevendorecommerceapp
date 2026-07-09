using FluentValidation;
using Entities.DTOs.Comment;
using Core.Utilities.Constants;

namespace Business.Validations.Comment;

public class CommentUpdateDtoValidator : AbstractValidator<CommentUpdateDto>
{
    public CommentUpdateDtoValidator()
    {
        // RuleFor(p => p.)
        //     .
    }
}
