using Div.Link.E_Commerce.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Data.Configuration
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        void IEntityTypeConfiguration<OrderItem>.Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(oi => oi.Id);

            builder.Property(oi => oi.Quantity)
                   .IsRequired()
                   .HasDefaultValue(1);

            builder.Property(oi => oi.Price)
                   .IsRequired()
                   .HasColumnType($"{SQLDataType.Decimal}(18,2)");

            builder.HasOne(oi => oi.Order)
                   .WithMany(o => o.OrderItems)
                   .HasForeignKey(oi => oi.OrderId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(oi => oi.Product)
                   .WithMany(p => p.OrderItems)
                   .HasForeignKey(oi => oi.ProductId)
                   .OnDelete(DeleteBehavior.Restrict);

            // تحسين الأداء
            builder.HasIndex(oi => oi.OrderId);
            builder.HasIndex(oi => oi.ProductId);

            // منع التكرار
            builder.HasIndex(oi => new { oi.OrderId, oi.ProductId })
                   .IsUnique();
        }
    }
}
