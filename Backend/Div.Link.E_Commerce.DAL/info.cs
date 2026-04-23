using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL
{
    internal class Info
    {

        #region MyRegion

        //builder.Property(p => p.Seller_Name)
        //   .HasColumnName("SellerName");
        //builder.Property(p => p.Seller_Name)
        //    .HasColumnType("varchar(100)");


        // Id




        //builder.HasIndex(p => p.Seller_Name)
        //    .HasDatabaseName("IX_Seller_Name")
        //    .IsUnique(false);

        //// builder.Property(e => e.creationdate)
        //    .HasDefaultValue(DateOnly.FromDateTime(DateTime.Now))XXXXX
        //    .HasComputedColumnSql("CAST(GETDATE() AS DATE)")
        //    //.HasColumnType("date");
        //    .HasColumnType(nameof(DataType.Date));
        // // date only 

        //builder.ToView("ProductsView", "dbo");
        // naming  Table
        //builder.ToTable("Products01","dbo");


        //.OnDelete(DeleteBehavior.Cascade);// Defult is Cascade, if parent is deleted then child will be deleted, if you want to restrict the delete then use Restrict 
        #endregion



    }
}
