namespace Entities.DTOs.Wishlist;

public class WishlistCreateDto
{
    public Guid ProductId {get; set;}
    public Guid UserId {get; set;}
    public DateTime CreatedAt = DateTime.UtcNow;
    public DateTime UpdatedAt = DateTime.UtcNow;
}
