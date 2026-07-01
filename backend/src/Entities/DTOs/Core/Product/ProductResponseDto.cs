namespace Entities.DTOs.Product;

public class ProductResponseDto
{
    public Guid Id {get; set;}
    public required string Title {get; set;}
    public string? Description {get; set;}
    public int Stock {get; set;} = 0;
    public decimal Price {get; set;}
    public int Discount {get; set;} = 0;
    public decimal DiscountedPrice => Price - (Price * Discount / 100);
    public long RatingReviewCount {get; set;} = 0;
    public long RatingPointSum {get; set;} = 0;
    public double Rating => (double)RatingPointSum / RatingReviewCount;
    public Guid? BrandId {get; set;}
    public Guid? CategoryId {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
