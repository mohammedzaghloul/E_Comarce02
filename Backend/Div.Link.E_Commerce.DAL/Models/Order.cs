using Div.Link.E_Commerce.DAL.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Models
{
    public class Order 
    {
        public int OrderId { get; set; }
        public DateTime Order_date { get; set; }
        public decimal Order_Amount { get; set; }
        public DateTime Shpiping_Date { get; set; }
        public OrderStatus Order_Satus { get; set; }
        public int CartId { get; set; }
        public int CustomerId { get; set; }
    } 

}
    

