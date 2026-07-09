using FluentValidation;
using Entities.DTOs.PaymentDetail;
using Core.Utilities.Constants;

namespace Business.Validations.PaymentDetail;

public class PaymentDetailUpdateDtoValidator : AbstractValidator<PaymentDetailUpdateDto>
{
    public PaymentDetailUpdateDtoValidator()
    {
        // RuleFor(p => p.)
        //     .
    }
}
