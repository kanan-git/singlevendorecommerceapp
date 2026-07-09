using FluentValidation;
using Entities.DTOs.ShippingDetail;
using Core.Utilities.Constants;

namespace Business.Validations.ShippingDetail;

public class ShippingDetailCreateDtoValidator : AbstractValidator<ShippingDetailCreateDto>
{
    public ShippingDetailCreateDtoValidator()
    {
        // RuleFor(p => p.)
        //     .
    }
}
