using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Concrete.Core;

namespace DataAccessLayer.Configurations;

public class CommentConfigurations : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        #region header
        builder.ToTable("Comments");
        builder.HasKey(com => com.Id);
        builder.Property<Guid>("Id");
        #endregion

        #region main
        // builder.Property(com => com.)
        #endregion
        
        #region relational
        // builder.Has
        #endregion
    }
}
