using FluentValidation;
using Entities.DTOs.CartItem;
using Core.Utilities.Constants;

namespace Business.Validations.CartItem;

public class CartItemUpdateDtoValidator : AbstractValidator<CartItemUpdateDto>
{
    public CartItemUpdateDtoValidator()
    {
        // RuleFor(p => p.)
        //     .
    }
}
