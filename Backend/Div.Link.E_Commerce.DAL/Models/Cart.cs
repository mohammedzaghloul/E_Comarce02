using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public int CustomerId { get; set; }
        public int ProductsId { get; set; }
        public float GrandTotal { get; set; }
        public int ItemTotal { get; set; }
    }
}
