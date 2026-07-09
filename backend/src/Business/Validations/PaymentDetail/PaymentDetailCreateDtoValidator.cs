using FluentValidation;
using Entities.DTOs.PaymentDetail;
using Core.Utilities.Constants;

namespace Business.Validations.PaymentDetail;

public class PaymentDetailCreateDtoValidator : AbstractValidator<PaymentDetailCreateDto>
{
    public PaymentDetailCreateDtoValidator()
    {
        // RuleFor(p => p.)
        //     .
    }
}
