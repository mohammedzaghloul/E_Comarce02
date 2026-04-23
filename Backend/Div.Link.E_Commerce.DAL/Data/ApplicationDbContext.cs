using Div.Link.E_Commerce.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Div.Link.E_Commerce.DAL.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCart> ProductCarts { get; set; }
        public DbSet<ProductSeller> ProductSellers { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        // public DbSet<User> Users { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
                .HasMany(c => c.ChildCategory)
                .WithOne(c => c.ParentCategory)
                .HasForeignKey(c => c.ParentCategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProductSeller>()
           .HasKey(ps => new { ps.ProductId, ps.SellerId });

            modelBuilder.Entity<ProductSeller>()
                   .HasOne(ps => ps.Product)
                   .WithMany(p => p.ProductSellers)
                   .HasForeignKey(ps => ps.ProductId);

            modelBuilder.Entity<ProductSeller>()
                   .HasOne(ps => ps.Seller)
                   .WithMany(s => s.ProductSellers)
                   .HasForeignKey(ps => ps.SellerId);

            modelBuilder.Entity<ProductCart>()
                   .HasKey(pc => new { pc.ProductId, pc.CartId });

            modelBuilder.Entity<ProductCart>()
                   .HasOne(pc => pc.Product)
                   .WithMany(p => p.ProductCarts)
                   .HasForeignKey(pc => pc.ProductId);

            modelBuilder.Entity<ProductCart>()
                   .HasOne(pc => pc.Cart)
                   .WithMany(c => c.ProductCarts)
                   .HasForeignKey(pc => pc.CartId);

            modelBuilder.Entity<Customer>()
                .HasOne(c => c.ApplicationUser)
                .WithOne(u => u.Customer)
                .HasForeignKey<Customer>(c => c.ApplicationUserId);

            modelBuilder.Entity<Seller>()
                .HasOne(s => s.ApplicationUser)
                .WithOne(u => u.Seller)
                .HasForeignKey<Seller>(s => s.ApplicationUserId);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());//reflecting all the configuration classes in the assembly and applying them to the model builder
        }
    }
}
