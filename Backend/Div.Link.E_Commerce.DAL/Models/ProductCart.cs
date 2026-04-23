using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Models
{
    public class ProductCart
    {
        public int ProductId { get; set; }
        public int CartId { get; set; }
        public Product Product { get; set; } = null!;  
        public Cart Cart { get; set; } = null!;
        public int Quantity { get; set; }
        public DateTime AddedAt { get; set; }
    }
}
