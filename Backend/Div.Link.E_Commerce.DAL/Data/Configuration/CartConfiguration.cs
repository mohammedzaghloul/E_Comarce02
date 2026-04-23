using Div.Link.E_Commerce.DAL.Data;
using Div.Link.E_Commerce.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Div.Link.E_Commerce.DAL.Data.Configuration
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.CustomerId)
                   .IsRequired();

            
            builder.HasOne(c => c.Customer)
                   .WithMany(cu => cu.Carts)
                   .HasForeignKey(c => c.CustomerId);

            
            builder.HasMany(c => c.Items)
                   .WithOne(ci => ci.Cart)
                   .HasForeignKey(ci => ci.CartId);

        }
    }
}