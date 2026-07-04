using FluentValidation;
using Entities.DTOs.Product;
using Core.Utilities.Constants;

namespace Business.Validations.Product;

public class ProductCreateDtoValidator : AbstractValidator<ProductCreateDto>
{
    public ProductCreateDtoValidator()
    {
        RuleFor(p => p.Title)
            .MinimumLength(1).WithMessage(ValidationMessages.MinSymbol(1))
            .MaximumLength(255).WithMessage(ValidationMessages.MaxSymbol(255))
            .NotNull().WithMessage(ValidationMessages.RequiredField);
        RuleFor(p => p.Description)
            .MaximumLength(255).WithMessage(ValidationMessages.MaxSymbol(255));
        RuleFor(p => p.Stock);
        RuleFor(p => p.Price)
            .NotNull().WithMessage(ValidationMessages.RequiredField);
        RuleFor(p => p.Discount);
        RuleFor(p => p.RatingReviewCount);
        RuleFor(p => p.RatingPointSum);
        RuleFor(p => p.BrandId);
        RuleFor(p => p.CategoryId);
    }
}
