namespace Entities.DTOs.Product;

public class ProductResponseDto
{
    public Guid Id {get; set;}
    public string Title {get; set;} = null!;
    public string? Description {get; set;}
    public int Stock {get; set;} = 0;
    public decimal Price {get; set;}
    public int Discount {get; set;} = 0;
    public decimal DiscountedPrice => Discount != 0 ? Price - (Price * Discount / 100) : 0;
    public long RatingReviewCount {get; set;} = 0;
    public long RatingPointSum {get; set;} = 0;
    public double Rating => RatingReviewCount != 0 ? (double)RatingPointSum / RatingReviewCount : 0;
    public Guid? BrandId {get; set;}
    public Guid? CategoryId {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
