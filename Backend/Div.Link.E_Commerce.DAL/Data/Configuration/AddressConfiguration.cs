using Div.Link.E_Commerce.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Data.Configuration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.StreetName)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(a => a.City)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(a => a.State)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(a => a.PinCode)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(a => a.City)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.HasOne(a => a.Customer)
                   .WithMany(c => c.Addresses)
                   .HasForeignKey(a => a.CustomerId);
        }
    }
}
