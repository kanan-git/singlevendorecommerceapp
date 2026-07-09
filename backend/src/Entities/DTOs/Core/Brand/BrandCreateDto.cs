namespace Entities.DTOs.Brand;

public class BrandCreateDto
{
    public string Name {get; set;} = null!;
    public DateTime CreatedAt = DateTime.UtcNow;
    public DateTime UpdatedAt = DateTime.UtcNow;
}
