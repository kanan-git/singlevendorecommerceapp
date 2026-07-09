namespace Entities.DTOs.Wishlist;

public class WishlistUpdateDto
{
    public Guid ProductId {get; set;}
    public Guid UserId {get; set;}
    public DateTime UpdatedAt = DateTime.UtcNow;
}
