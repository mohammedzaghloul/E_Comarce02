using Div.Link.E_Commerce.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Data.Configuration
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
                builder.Property(c => c.Name)
                    .HasMaxLength(100)
                    .IsRequired();
    
                builder.Property(c => c.Description)
                    .HasMaxLength(500);
    
                builder.HasMany(c => c.Children)
                    .WithOne(c => c.ParentCategory)
                    .HasForeignKey(c => c.ParentCategoryId)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
