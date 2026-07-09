using FluentValidation;
using Entities.DTOs.Order;
using Core.Utilities.Constants;

namespace Business.Validations.Order;

public class OrderCreateDtoValidator : AbstractValidator<OrderCreateDto>
{
    public OrderCreateDtoValidator()
    {
        // RuleFor(p => p.)
        //     .
    }
}
