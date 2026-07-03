using Entities.Common;

namespace Entities.Concrete.Core;

public class MediaFile : BaseEntity
{
    #region main
    public string FilePath {get; set;} = null!;
    public string FileType {get; set;} = null!;
    public long FileSize {get; set;}
    #endregion

    #region relational
    public string EntityType {get; set;} = null!;
    public Guid EntityId {get; set;}
    #endregion
}
