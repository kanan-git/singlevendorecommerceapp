using FluentValidation;
using Entities.DTOs.ShippingDetail;
using Core.Utilities.Constants;

namespace Business.Validations.ShippingDetail;

public class ShippingDetailUpdateDtoValidator : AbstractValidator<ShippingDetailUpdateDto>
{
    public ShippingDetailUpdateDtoValidator()
    {
        // RuleFor(p => p.)
        //     .
    }
}
