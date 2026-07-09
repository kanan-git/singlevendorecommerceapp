namespace Entities.DTOs.Brand;

public class BrandUpdateDto
{
    public string Name {get; set;} = null!;
    public DateTime UpdatedAt = DateTime.UtcNow;
}
