namespace Entities.DTOs.MediaFile;

public class MediaFileCreateDto
{
    public string FilePath {get; set;} = null!;
    public string FileType {get; set;} = null!;
    public long FileSize {get; set;}
    public string EntityType {get; set;} = null!;
    public Guid EntityId {get; set;}
    public DateTime CreatedAt = DateTime.UtcNow;
    public DateTime UpdatedAt = DateTime.UtcNow;
}
