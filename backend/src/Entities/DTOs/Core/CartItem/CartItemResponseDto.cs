namespace Entities.DTOs.CartItem;

public class CartItemResponseDto
{
    public Guid Id {get; set;}
    public int Quantity {get; set;}
    public Guid UserId {get; set;}
    public Guid ProductId {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
