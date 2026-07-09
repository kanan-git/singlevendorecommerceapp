namespace Entities.DTOs.Coupon;

public class CouponResponseDto
{
    public Guid Id {get; set;}
    public string Code {get; set;} = string.Empty; // e.g., SUMMER50
    public int DiscountValue {get; set;}
    public DateTime ExpiryDate {get; set;}
    public int MaxUsage {get; set;}
    public int CurrentUsage {get; set;}
    public bool IsActive {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
