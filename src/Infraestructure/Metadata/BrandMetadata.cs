using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Metadata
{
    public class BrandMetadata : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(x => x.Name)
                .HasMaxLength(250)
                .IsRequired();

            builder.HasQueryFilter(x => x.IsDeleted == false);
        }
    }
}
