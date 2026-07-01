using Entities.Common;

namespace Entities.Concrete.Core;

public class MediaFile : BaseEntity
{
    #region main
    public required string FilePath {get; set;}
    public required string FileType {get; set;}
    public long FileSize {get; set;}
    #endregion

    #region relational
    public required string EntityType {get; set;}
    public Guid EntityId {get; set;}
    #endregion
}
