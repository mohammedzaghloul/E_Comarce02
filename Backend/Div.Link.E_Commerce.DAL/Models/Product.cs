using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Models
{
    public class Product : BaseEntity
    {
        public string Seller_Name { get; set; }
        public decimal MRP { get; set; }
        public byte Stock { get; set; }
        public string Brand { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;// creation null for given 
        public int SellerId { get; set; }
        public ICollection<ProductCart> ProductCarts { get; set; } = new HashSet<ProductCart>();
        public ICollection<ProductSeller> ProductSellers { get; set; } = new List<ProductSeller>();

    }
}