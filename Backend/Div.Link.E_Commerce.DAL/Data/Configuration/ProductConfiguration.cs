using Div.Link.E_Commerce.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id).UseIdentityColumn();

            builder.Property(builder => builder.Price)
               .HasColumnType($"{SQLDataType.Decimal}(18,2)")
               .IsRequired();

            builder.HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);


            builder.HasOne(p => p.Brand)
       .WithMany(b => b.Products)
       .HasForeignKey(p => p.BrandId)
       .OnDelete(DeleteBehavior.Restrict);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(p => p.Description)
                .HasMaxLength(1000);

            builder.Property(p => p.Stock)
                .IsRequired();

            builder.Property(p => p.CategoryId)
                .IsRequired();

            builder.Property(p => p.SellerId)
               .IsRequired();




        }
    }
}
