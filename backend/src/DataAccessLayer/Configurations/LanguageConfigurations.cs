using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Concrete.Core;

namespace DataAccessLayer.Configurations;

public class LanguageConfigurations : IEntityTypeConfiguration<Language>
{
    public void Configure(EntityTypeBuilder<Language> builder)
    {
        #region header
        builder.ToTable("Languages");
        builder.HasKey(l => l.Id);
        builder.Property<Guid>("Id");
        #endregion

        #region main
        // builder.Property(l => l.)
        #endregion
        
        #region relational
        // builder.Has
        #endregion
    }
}
