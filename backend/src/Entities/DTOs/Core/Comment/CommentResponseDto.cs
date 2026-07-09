namespace Entities.DTOs.Comment;

public class CommentResponseDto
{
    public Guid Id {get; set;}
    public string? TextContent {get; set;} 
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
