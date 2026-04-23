using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Models
{
    public class Seller
    {
        public int SellerId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public decimal Total_Sales { get; set; }
    }
}
