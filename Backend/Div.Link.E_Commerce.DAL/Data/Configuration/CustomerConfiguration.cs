using Div.Link.E_Commerce.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Data.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();

            builder.HasMany(c => c.Carts)
                   .WithOne(cart => cart.Customer)
                   .HasForeignKey(cart => cart.CustomerId); 

            builder.HasMany(c => c.Addresses)
                   .WithOne(a => a.Customer)
                   .HasForeignKey(a => a.CustomerId)
                   .OnDelete(DeleteBehavior.Cascade);   

            builder.HasMany(c => c.Orders)
                   .WithOne(o => o.Customer)
                   .HasForeignKey(o => o.CustomerId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.ApplicationUser)
                   .WithOne(au => au.Customer)
                   .HasForeignKey<Customer>(c => c.ApplicationUserId)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
