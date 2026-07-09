using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Concrete.Core;

namespace DataAccessLayer.Configurations;

public class MediaFileConfigurations : IEntityTypeConfiguration<MediaFile>
{
    public void Configure(EntityTypeBuilder<MediaFile> builder)
    {
        #region header
        builder.ToTable("MediaFiles");
        builder.HasKey(mf => mf.Id);
        builder.Property<Guid>("Id");
        #endregion

        #region main
        // builder.Property(mf => mf.)
        #endregion
        
        #region relational
        // builder.Has
        #endregion
    }
}
