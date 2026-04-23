using Div.Link.E_Commerce.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ApplicationUser> builder)
        {

            builder.Property(u => u.UserName).HasMaxLength(50);

            builder.HasOne(a=>a.Customer)
                   .WithOne(c => c.ApplicationUser)
                   .HasForeignKey<Customer>(c => c.ApplicationUserId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(a => a.Seller)
                   .WithOne(s => s.ApplicationUser)
                   .HasForeignKey<Seller>(s => s.ApplicationUserId)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
