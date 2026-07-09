using FluentValidation;
using Entities.DTOs.CartItem;
using Core.Utilities.Constants;

namespace Business.Validations.CartItem;

public class CartItemCreateDtoValidator : AbstractValidator<CartItemCreateDto>
{
    public CartItemCreateDtoValidator()
    {
        // RuleFor(p => p.)
        //     .
    }
}
