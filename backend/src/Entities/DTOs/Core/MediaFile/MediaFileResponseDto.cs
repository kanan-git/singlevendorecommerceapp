namespace Entities.DTOs.MediaFile;

public class MediaFileResponseDto
{
    public Guid Id {get; set;}
    public string FilePath {get; set;} = null!;
    public string FileType {get; set;} = null!;
    public long FileSize {get; set;}
    public string EntityType {get; set;} = null!;
    public Guid EntityId {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
