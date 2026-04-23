using Div.Link.E_Commerce.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Data.Configuration
{
    public class BrandTypeConfiguration : IEntityTypeConfiguration<BrandType>
    {
        public void Configure(EntityTypeBuilder<BrandType> builder)
        {
            builder.HasKey(bt => bt.Id);

            builder.Property(bt => bt.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.HasIndex(bt => bt.Name)
                   .IsUnique();

        }
    }
}
