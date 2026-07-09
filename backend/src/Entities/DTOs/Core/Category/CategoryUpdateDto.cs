namespace Entities.DTOs.Category;

public class CategoryUpdateDto
{
    public string Name {get; set;} = null!;
    public DateTime UpdatedAt = DateTime.UtcNow;
}
