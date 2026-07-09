namespace Entities.DTOs.CartItem;

public class CartItemUpdateDto
{
    public int Quantity {get; set;}
    public Guid UserId {get; set;}
    public Guid ProductId {get; set;}
    public DateTime UpdatedAt = DateTime.UtcNow;
}
