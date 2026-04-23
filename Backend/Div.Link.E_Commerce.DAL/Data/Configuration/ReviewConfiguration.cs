using Div.Link.E_Commerce.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Data.Configuration
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasIndex(r => new { r.ProductId, r.CustomerId })
                   .IsUnique();
            builder.HasOne(r => r.Product)
                   .WithMany(p => p.Reviews)
                   .HasForeignKey(r => r.ProductId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(r => r.Customer)
                   .WithMany(c => c.Reviews)
                   .HasForeignKey(r => r.CustomerId)
                   .OnDelete(DeleteBehavior.Restrict);
            builder.Property(r => r.Rating)
                   .HasConversion<string>()
                   .IsRequired();
            builder.Property(r => r.Description)
                   .HasMaxLength(1000);
            builder.Property(r => r.CreatedAt)
                   .HasDefaultValueSql("GETUTCDATE()")
                   .ValueGeneratedOnAdd();
            builder.HasIndex(r => r.ProductId);
            builder.HasIndex(r => r.CustomerId);
        }
    }
}
