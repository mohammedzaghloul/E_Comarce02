using Div.Link.E_Commerce.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Data.Configuration
{
    public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder.HasKey(ci => new { ci.CartId, ci.ProductId });

            builder.Property(ci => ci.CartId)
                   .IsRequired();

            builder.Property(ci => ci.ProductId)
                   .IsRequired();

            builder.Property(ci => ci.Quantity)
                   .IsRequired();

            builder.Property(ci => ci.Price)
                   .IsRequired()
                   .HasColumnType($"{SQLDataType.Decimal}(18,2)");

            builder.HasOne(ci => ci.Cart)
                   .WithMany(c => c.Items)
                   .HasForeignKey(ci => ci.CartId);


        }
    }
}