using FluentValidation;
using Entities.DTOs.Order;
using Core.Utilities.Constants;

namespace Business.Validations.Order;

public class OrderUpdateDtoValidator : AbstractValidator<OrderUpdateDto>
{
    public OrderUpdateDtoValidator()
    {
        // RuleFor(p => p.)
        //     .
    }
}
