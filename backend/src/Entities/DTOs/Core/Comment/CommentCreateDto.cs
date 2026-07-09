namespace Entities.DTOs.Comment;

public class CommentCreateDto
{
    public string? TextContent {get; set;} 
    public DateTime CreatedAt = DateTime.UtcNow;
    public DateTime UpdatedAt = DateTime.UtcNow;
}
