using Div.Link.E_Commerce.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Data.Configuration
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.Property(p => p.Amount)
         .HasColumnType($"{SQLDataType.Decimal}(18,2)")
         .IsRequired();

            builder.Property(p => p.PaymentMode)
                   .HasConversion<string>();

            builder.Property(p => p.Status)
                   .HasConversion<string>();

            builder.HasOne(p => p.Order)
                   .WithMany(o => o.Payments)
                   .HasForeignKey(p => p.OrderId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}   