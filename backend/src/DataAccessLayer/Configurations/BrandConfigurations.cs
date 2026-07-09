using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Concrete.Core;

namespace DataAccessLayer.Configurations;

public class BrandConfigurations : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        #region header
        builder.ToTable("Brands");
        builder.HasKey(b => b.Id);
        builder.Property<Guid>("Id");
        #endregion

        #region main
        // builder.Property(b => b.)
        #endregion
        
        #region relational
        // builder.Has
        #endregion
    }
}
