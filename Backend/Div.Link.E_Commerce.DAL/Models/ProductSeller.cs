using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Models
{
    public class ProductSeller
    {
        public int ProductId { get; set; }
        public int SellerId { get; set; }

        public Product Product { get; set; } = null!;
        public Seller Seller { get; set; } = null!;
    }
}
