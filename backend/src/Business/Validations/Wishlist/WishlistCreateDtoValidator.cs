using FluentValidation;
using Entities.DTOs.Wishlist;
using Core.Utilities.Constants;

namespace Business.Validations.Wishlist;

public class WishlistCreateDtoValidator : AbstractValidator<WishlistCreateDto>
{
    public WishlistCreateDtoValidator()
    {
        // RuleFor(p => p.)
        //     .
    }
}
