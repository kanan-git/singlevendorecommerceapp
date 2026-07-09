namespace Entities.DTOs.Comment;

public class CommentUpdateDto
{
    public string? TextContent {get; set;} 
    public DateTime UpdatedAt = DateTime.UtcNow;
}
