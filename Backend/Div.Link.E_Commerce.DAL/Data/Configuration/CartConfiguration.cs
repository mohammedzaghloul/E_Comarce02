using Div.Link.E_Commerce.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CartConfiguration : IEntityTypeConfiguration<Cart>
{
    public void Configure(EntityTypeBuilder<Cart> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.CustomerId)
               .IsRequired();

        builder.Property(c => c.GrandTotal)
               .HasColumnType("decimal(18,2)")
               .IsRequired();

        builder.Property(c => c.ItemTotal)
               .HasColumnType("decimal(18,2)")
               .IsRequired();

        builder.HasMany(c => c.ProductCarts)
               .WithOne(pc => pc.Cart)
               .HasForeignKey(pc => pc.CartId);

        builder.HasOne(c => c.Customer)
               .WithMany(cu => cu.Carts)
               .HasForeignKey(c => c.CustomerId);
        
    }
}