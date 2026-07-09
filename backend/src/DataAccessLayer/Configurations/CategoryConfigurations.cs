using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Concrete.Core;

namespace DataAccessLayer.Configurations;

public class CategoryConfigurations : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        #region header
        builder.ToTable("Categories");
        builder.HasKey(ctg => ctg.Id);
        builder.Property<Guid>("Id");
        #endregion

        #region main
        // builder.Property(ctg => ctg.)
        #endregion
        
        #region relational
        // builder.Has
        #endregion
    }
}
