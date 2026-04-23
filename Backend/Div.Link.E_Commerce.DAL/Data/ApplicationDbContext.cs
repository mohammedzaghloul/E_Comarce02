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
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<CartItem> CartItems { get; set; }  
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Address>Addresses { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<BrandType> BrandTypes { get; set; }
        #region ADV
        //public DbSet<Discount> Discounts { get; set; }
        //public DbSet<Wishlist> Wishlists { get; set; }
        //public DbSet<WishlistItem> WishlistItems { get; set; }
        //public DbSet<Shipping> Shippings { get; set; }
        //public DbSet<ShippingMethod> ShippingMethods { get; set; }
        //public DbSet<Inventory> Inventories { get; set; }
        //public DbSet<InventoryTransaction> InventoryTransactions { get; set; }
        //public DbSet<Notification> Notifications { get; set; }
        //public DbSet<NotificationType> NotificationTypes { get; set; }
        //public DbSet<ReturnRequest> ReturnRequests { get; set; }
        //public DbSet<ReturnRequestItem> ReturnRequestItems { get; set; }
        //public DbSet<PaymentMethod> PaymentMethods { get; set; }
        //public DbSet<PaymentTransaction> PaymentTransactions { get; set; }
        //public DbSet<Promotion> Promotions { get; set; }    
        //public DbSet<PromotionProduct> PromotionProducts { get; set; }
        //public DbSet<PromotionCategory> PromotionCategories { get; set; }
        //public DbSet<PromotionBrand> PromotionBrands { get; set; }
        //public DbSet<PromotionSeller> PromotionSellers { get; set; }
        //public DbSet<PromotionCustomer> PromotionCustomers { get; set; }
        //public DbSet<PromotionType> PromotionTypes { get; set; }
        //public DbSet<PromotionUsage> PromotionUsages { get; set; }
        //public DbSet<PromotionUsageHistory> PromotionUsageHistories { get; set; }
        //public DbSet<PromotionRule> PromotionRules { get; set; }
        //public DbSet<PromotionAction> PromotionActions { get; set; }
        //public DbSet<PromotionReward> PromotionRewards { get; set; }
        //public DbSet<PromotionCondition> PromotionConditions { get; set; }
        //public DbSet<PromotionBenefit> PromotionBenefits { get; set; }
        //public DbSet<PromotionRestriction> PromotionRestrictions { get; set; }
        //public DbSet<PromotionRequirement> PromotionRequirements { get; set; }
        //public DbSet<PromotionExclusion> PromotionExclusions { get; set; }
        //public DbSet<PromotionInclusion> PromotionInclusions { get; set; }
        //public DbSet<PromotionApplication> PromotionApplications { get; set; }
        //public DbSet<PromotionResult> PromotionResults { get; set; }
        //public DbSet<PromotionEvaluation> PromotionEvaluations { get; set; }
        //public DbSet<PromotionRedemption> PromotionRedemptions { get; set; }
        //public DbSet<PromotionRedemptionHistory> PromotionRedemptionHistories { get; set; }
        //public DbSet<PromotionRedemptionResult> PromotionRedemptionResults { get; set; }
        //public DbSet<PromotionRedemptionEvaluation> PromotionRedemptionEvaluations { get; set; }
        //public DbSet<PromotionRedemptionRestriction> PromotionRedemptionRestrictions { get; set; }
        //public DbSet<PromotionRedemptionRequirement> PromotionRedemptionRequirements { get; set; }
        //public DbSet<PromotionRedemptionExclusion> PromotionRedemptionExclusions { get; set; }
        //public DbSet<PromotionRedemptionInclusion> PromotionRedemptionInclusions { get; set; }
        //public DbSet<PromotionRedemptionApplication> PromotionRedemptionApplications { get; set; }
        //public DbSet<PromotionRedemptionResult> PromotionRedemptionResults { get; set; }
        //public DbSet<PromotionRedemptionEvaluation> PromotionRedemptionEvaluations { get; set; }
        //public DbSet<PromotionRedemptionRestriction> PromotionRedemptionRestrictions { get; set; }
        //public DbSet<PromotionRedemptionRequirement> PromotionRedemptionRequirements { get; set; }
        //public DbSet<PromotionRedemptionExclusion> PromotionRedemptionExclusions { get; set; }
        //public DbSet<PromotionRedemptionInclusion> PromotionRedemptionInclusions { get; set; }  
        //public DbSet<PromotionRedemptionApplication> PromotionRedemptionApplications { get; set; }
        //public DbSet<PromotionRedemptionResult> PromotionRedemptionResults { get; set; }
        //public DbSet<PromotionRedemptionEvaluation> PromotionRedemptionEvaluations { get; set; }
        //public DbSet<PromotionRedemptionRestriction> PromotionRedemptionRestrictions { get; set; }
        //public DbSet<PromotionRedemptionRequirement> PromotionRedemptionRequirements { get; set; }
        //public DbSet<PromotionRedemptionExclusion> PromotionRedemptionExclusions { get; set; }
        //public DbSet<PromotionRedemptionInclusion> PromotionRedemptionInclusions { get; set; }
        //public DbSet<PromotionRedemptionApplication> PromotionRedemptionApplications { get; set; }
        //public DbSet<PromotionRedemptionResult> PromotionRedemptionResults { get; set; }
        //public DbSet<PromotionRedemptionEvaluation> PromotionRedemptionEvaluations { get; set; }
        //public DbSet<PromotionRedemptionRestriction> PromotionRedemptionRestrictions { get; set; }
        //public DbSet<PromotionRedemptionRequirement> PromotionRedemptionRequirements { get; set; }
        //public DbSet<PromotionRedemptionExclusion> PromotionRedemptionExclusions { get; set; }
        //public DbSet<PromotionRedemptionInclusion> PromotionRedemptionInclusions { get; set; }
        //public DbSet<PromotionRedemptionApplication> PromotionRedemptionApplications { get; set; } 
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           

            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Cart)
                .WithMany(c => c.Items)
                .HasForeignKey(ci => ci.CartId);

            modelBuilder.Entity<CartItem>()
          .HasOne(ci => ci.Cart)
          .WithMany(c => c.Items)
          .HasForeignKey(ci => ci.CartId);

            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Product)
                .WithMany()
                .HasForeignKey(ci => ci.ProductId);

            modelBuilder.Entity<Customer>()
                .HasOne(c => c.ApplicationUser)
                .WithOne(u => u.Customer)
                .HasForeignKey<Customer>(c => c.ApplicationUserId);

            modelBuilder.Entity<Seller>()
                .HasOne(s => s.ApplicationUser)
                .WithOne(u => u.Seller)
                .HasForeignKey<Seller>(s => s.ApplicationUserId);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); 
            //reflecting all the configuration classes in the assembly and applying them to the model builder
        }
    }
}
