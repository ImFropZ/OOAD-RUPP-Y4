using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductLib;

namespace ProductApi;

public class ProductEnityTypeConfig : IEntityTypeConfiguration<Product>
{
  public void Configure(EntityTypeBuilder<Product> builder)
  {

    builder.ToTable("Product");

    builder.HasKey(p => p.Id);
    builder.Property(p => p.Id).ValueGeneratedOnAdd();
    builder.Property(p => p.Code).IsRequired();
    builder.HasIndex(p => p.Code).IsUnique();
    builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
    builder.Property(p => p.Category).IsRequired();
    builder.Property(p => p.CreatedOn).HasColumnType("timestamp without time zone");
    builder.Property(p => p.LastUpdatedOn).HasColumnType("timestamp without time zone");
  }
}