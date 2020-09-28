using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Metadata
{
    public class ProductMetadata : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Name)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(x => x.Cost)
                .IsRequired();

            builder.Property(x => x.Price)
                .IsRequired();

            builder.HasQueryFilter(x => x.IsDeleted == false);
        }
    }
}
