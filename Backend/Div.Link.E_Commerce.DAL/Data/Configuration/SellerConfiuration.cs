using Div.Link.E_Commerce.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Data.Configuration
{
    public class SellerConfiuration : IEntityTypeConfiguration<Seller>
    {
        public void Configure(EntityTypeBuilder<Seller> builder)
        {
            builder.HasOne(s => s.ApplicationUser)
                   .WithOne(u => u.Seller)
                   .HasForeignKey<Seller>(s => s.ApplicationUserId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.Property(s => s.Total_Sales)
                   .HasColumnType($"{SQLDataType.Decimal}(18,2)")
                   .HasDefaultValue(0);

            builder.Property(s => s.StoreName)
                   .HasColumnType($"{SQLDataType.Nvarchar}(100)")
                   .IsRequired();

             builder.Property(s => s.Description)
                   .HasColumnType($"{SQLDataType.Nvarchar}(500)")
                   .IsRequired(false);

            builder.HasMany(s => s.Products)
                   .WithOne(p => p.Seller)
                   .HasForeignKey(p => p.SellerId)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
