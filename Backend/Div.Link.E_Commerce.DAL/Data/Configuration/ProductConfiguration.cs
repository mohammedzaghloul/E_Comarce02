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
            //builder.ToView("ProductsView", "dbo");
            // naming  Table
            //builder.ToTable("Products01","dbo");
            builder.Property(builder => builder.MRP)
                .HasColumnType("decimal(18,2)")
                .IsRequired();
            builder.Property(a=>a.Id).UseIdentityColumn();
            #region MyRegion

            builder.Property(p => p.Seller_Name)
                .HasMaxLength(100)
                .IsRequired();

            //builder.Property(p => p.Seller_Name)
            //   .HasColumnName("SellerName");
            //builder.Property(p => p.Seller_Name)
            //    .HasColumnType("varchar(100)");
            builder.Property(p => p.Seller_Name)
                .HasColumnType($"{SQLDataType.nvarchar}")
                .HasMaxLength(100)
                .IsRequired();
            // .HasAnnotation("MaxLength", 100);

            builder.Property(p => p.Brand)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.Stock)
                .IsRequired();

            builder.Property(p => p.CategoryId)
                .IsRequired();

            builder.Property(p => p.SellerId)
               .IsRequired(); 
            #endregion
            // Id

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id)
            .UseIdentityColumn(10,1);

            builder.HasIndex(p => p.Seller_Name)
                .HasDatabaseName("IX_Seller_Name")
                .IsUnique(false);

            // builder.Property(e => e.creationdate)
            //    .HasDefaultValue(DateOnly.FromDateTime(DateTime.Now))XXXXX
            //    .HasComputedColumnSql("CAST(GETDATE() AS DATE)")
            //    //.HasColumnType("date");
            //    .HasColumnType(nameof(DataType.Date));
            //// date only 


            builder.HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);
                //.OnDelete(DeleteBehavior.Cascade);// Defult is Cascade, if parent is deleted then child will be deleted, if you want to restrict the delete then use Restrict



        }
    }
}
