using FluentValidation;
using Entities.DTOs.Coupon;
using Core.Utilities.Constants;

namespace Business.Validations.Coupon;

public class CouponCreateDtoValidator : AbstractValidator<CouponCreateDto>
{
    public CouponCreateDtoValidator()
    {
        // RuleFor(p => p.)
        //     .
    }
}
