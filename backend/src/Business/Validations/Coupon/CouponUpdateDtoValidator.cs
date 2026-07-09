using FluentValidation;
using Entities.DTOs.Coupon;
using Core.Utilities.Constants;

namespace Business.Validations.Coupon;

public class CouponUpdateDtoValidator : AbstractValidator<CouponUpdateDto>
{
    public CouponUpdateDtoValidator()
    {
        // RuleFor(p => p.)
        //     .
    }
}
