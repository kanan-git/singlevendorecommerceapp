namespace Entities.Common;

public class BaseEntity
{
    public Guid Id {get; set;} // note: only response dto, not update and create
    public DateTime CreatedAt = DateTime.UtcNow;
    public DateTime UpdatedAt {get; set;}
};
