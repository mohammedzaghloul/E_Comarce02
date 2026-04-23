using Div.Link.E_Commerce.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Data.Configuration
{
    internal class OrderConfiguration : IEntityTypeConfiguration<Models.Order>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Models.Order> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property(o => o.Orderdate)
                .IsRequired();

            builder.Property(o => o.OrderAmount)
                .IsRequired()
                .HasColumnType($"{SQLDataType.Decimal}(18,2)");

            builder.Property(o => o.OrderStatus)
                .HasConversion<int>();

            builder.HasOne(o => o.Customer)
                   .WithMany(c => c.Orders)
                   .HasForeignKey(o => o.CustomerId)
                   .OnDelete(DeleteBehavior.Cascade);
        
            builder.Property(o=>o.ShippingDate)
                .IsRequired(false);

            builder.Property(o => o.Orderdate)
          .HasDefaultValueSql("GETDATE()");

        }
    }

}

