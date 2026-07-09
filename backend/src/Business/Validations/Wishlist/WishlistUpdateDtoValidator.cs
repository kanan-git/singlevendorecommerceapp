using FluentValidation;
using Entities.DTOs.Wishlist;
using Core.Utilities.Constants;

namespace Business.Validations.Wishlist;

public class WishlistUpdateDtoValidator : AbstractValidator<WishlistUpdateDto>
{
    public WishlistUpdateDtoValidator()
    {
        // RuleFor(p => p.)
        //     .
    }
}
