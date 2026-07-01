using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Concrete.Core;

namespace DataAccessLayer.Configurations;

public class ProductConfigurations : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        #region header
        builder.ToTable("Products");
        builder.HasKey(p => p.Id);
        builder.Property<Guid>("Id");
        #endregion

        #region main
        builder.Property(p => p.Title)
            .HasMaxLength(255)
            .HasColumnType(SqlDbType.NVarChar.ToString())
            .IsRequired();
        builder.Property(p => p.Description)
            .HasMaxLength(255)
            .HasColumnType(SqlDbType.NVarChar.ToString());
        builder.Property(p => p.Stock)
            .HasDefaultValue(0);
        builder.Property(p => p.Price)
            .HasDefaultValue(0)
            .IsRequired();
        builder.Property(p => p.Discount)
            .HasDefaultValue(0);
        builder.Property(p => p.DiscountedPrice)
            .HasDefaultValue(0);
        builder.Property(p => p.RatingReviewCount)
            .HasDefaultValue(0);
        builder.Property(p => p.RatingPointSum)
            .HasDefaultValue(0);
        builder.Property(p => p.Rating)
            .HasDefaultValue(0);
        builder.Property(p => p.BrandId);
        builder.Property(p => p.CategoryId);
        #endregion

        #region relational
        // builder.HasOne(p => p.Brand).WithOne(b => b.).HasForeignKey(p => p.).OnDelete();
        // builder.HasOne(p => p.Category).WithOne(ctg => ctg.).HasForeignKey(p => p.).OnDelete();
        // builder.HasOne(p => p.ImgPath).WithMany(mf => mf.).HasForeignKey(p => p.).OnDelete();
        // builder.HasOne(p => p.Comments).WithMany(cm => cm.).HasForeignKey(p => p.).OnDelete();
        #endregion
    }
}
