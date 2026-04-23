using Div.Link.E_Commerce.DAL.Models.BaseClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public int SellerId { get; set; }
        public Seller Seller { get; set; } = null!;
        public ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();
        public ICollection<Review> Reviews { get; set; } = new HashSet<Review>();
        public int BrandId { get; set; }          // FK
        public Brand Brand { get; set; } = null!; // Navigation

    }
}