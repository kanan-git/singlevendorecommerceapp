using FluentValidation;
using Entities.DTOs.Comment;
using Core.Utilities.Constants;

namespace Business.Validations.Comment;

public class CommentCreateDtoValidator : AbstractValidator<CommentCreateDto>
{
    public CommentCreateDtoValidator()
    {
        // RuleFor(p => p.)
        //     .
    }
}
