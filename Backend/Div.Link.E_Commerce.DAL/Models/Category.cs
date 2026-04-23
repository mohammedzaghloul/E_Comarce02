using Div.Link.E_Commerce.DAL.Models.BaseClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Models
{
    #region Flunt
    //modelBuilder.Entity<Category>()
    //          .HasMany(c => c.ChildCategory)
    //          .WithOne(c => c.ParentCategory)
    //          .HasForeignKey(c => c.ParentCategoryId)
    //          .OnDelete(DeleteBehavior.Restrict); 
    #endregion
    public class Category : BaseEntity // self referencing table one to many relationship with itself
    {
        public string Name { get; set; }= null!;
        public string? Description { get; set; }
        public ICollection<Product> Products { get; set; }=new HashSet<Product>();
        // one to many relationship with Product
        public  Category ParentCategory{ get; set; }=null!;
        [ForeignKey("ParentCategory")]
        public int? ParentCategoryId { get; set; }
        public ICollection<Category> Children  { get; set; }=new HashSet<Category>();
    }
}
