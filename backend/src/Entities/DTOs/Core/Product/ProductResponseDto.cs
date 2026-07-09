using Core.Utilities.Features;

namespace Entities.DTOs.Product;

public class ProductResponseDto
{
    public Guid Id {get; set;}
    public string Title {get; set;} = null!;
    public string? Description {get; set;}
    public int Stock {get; set;} = 0;
    public decimal Price {get; set;}
    public int Discount {get; set;} = 0;
    public decimal DiscountedPrice => ProductUtils.FindDiscountedPrice(Price, Discount);
    public long RatingReviewCount {get; set;} = 0;
    public long RatingPointSum {get; set;} = 0;
    public double Rating => ProductUtils.FindRating(RatingReviewCount, RatingPointSum);
    public string? Color {get; set;}
    public Guid? BrandId {get; set;}
    public string BrandName {get; set;}
    public Guid? CategoryId {get; set;}
    public string CategoryName {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
