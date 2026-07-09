namespace Entities.DTOs.CartItem;

public class CartItemCreateDto
{
    public int Quantity {get; set;}
    public Guid UserId {get; set;}
    public Guid ProductId {get; set;}
    public DateTime CreatedAt = DateTime.UtcNow;
    public DateTime UpdatedAt = DateTime.UtcNow;
}
