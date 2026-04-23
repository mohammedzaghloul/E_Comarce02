using Div.Link.E_Commerce.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Div.Link.E_Commerce.DAL.Data.Configuration
{
    internal class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name)
                   .IsRequired()
                   .HasMaxLength(100);

           
            builder.HasIndex(b => b.Name)
                   .IsUnique();

       
            builder.HasOne(b => b.BrandType)
                   .WithMany(bt => bt.Brands)
                   .HasForeignKey(b => b.BrandTypeId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}