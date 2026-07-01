namespace Entities.DTOs.Product;

public class ProductUpdateDto
{
    public required string Title {get; set;}
    public string? Description {get; set;}
    public int Stock {get; set;} = 0;
    public decimal Price {get; set;}
    public int Discount {get; set;} = 0;
    public long RatingReviewCount {get; set;} = 0;
    public long RatingPointSum {get; set;} = 0;
    public Guid? BrandId {get; set;}
    public Guid? CategoryId {get; set;}
    public DateTime UpdatedAt = DateTime.UtcNow;
}
