namespace Entities.DTOs.Category;

public class CategoryResponseDto
{
    public Guid Id {get; set;}
    public string Name {get; set;} = null!;
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
