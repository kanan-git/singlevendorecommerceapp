namespace Entities.DTOs.Coupon;

public class CouponCreateDto
{
    public string Code {get; set;} = string.Empty; // e.g., SUMMER50
    public int DiscountValue {get; set;}
    public DateTime ExpiryDate {get; set;}
    public int MaxUsage {get; set;}
    public int CurrentUsage {get; set;}
    public bool IsActive {get; set;}
    public DateTime CreatedAt = DateTime.UtcNow;
    public DateTime UpdatedAt = DateTime.UtcNow;
}
