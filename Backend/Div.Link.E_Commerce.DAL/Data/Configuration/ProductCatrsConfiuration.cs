using Div.Link.E_Commerce.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Data.Configuration
{
    internal class ProductCatrsConfiuration : IEntityTypeConfiguration<ProductCart>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ProductCart> builder)
        {
            builder.HasKey(pc => new { pc.ProductId, pc.CartId });
            builder.HasOne(pc => pc.Product)
                   .WithMany(p => p.ProductCarts)
                   .HasForeignKey(pc => pc.ProductId);
            builder.HasOne(pc => pc.Cart)
                   .WithMany(c => c.ProductCarts)
                   .HasForeignKey(pc => pc.CartId);
        }
    }
}
