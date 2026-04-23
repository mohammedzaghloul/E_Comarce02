using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public int Quantity { get; set; }

        //Maximum Retail Price
        public decimal MRP { get; set; }

    }
}
