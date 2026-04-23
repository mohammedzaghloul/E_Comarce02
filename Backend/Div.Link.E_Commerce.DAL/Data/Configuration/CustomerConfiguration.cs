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
            builder.HasOne(c => c.Address)
                   .WithMany()
                   .HasForeignKey(c => c.AddressId)
                   .OnDelete(DeleteBehavior.Cascade);   
        }
    }
}
