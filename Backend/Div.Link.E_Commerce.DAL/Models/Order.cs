using Div.Link.E_Commerce.DAL.Helper;
using Div.Link.E_Commerce.DAL.Models.BaseClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Models
{
    public class Order : BaseEntity
    {
        public DateTime Orderdate { get; set; }= DateTime.UtcNow;
        public decimal OrderAmount { get; set; }
        public DateTime? ShippingDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public int CartId { get; set; }
        public Cart Cart { get; set; } = null!;
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>(); 
        public ICollection<Payment> Payments { get; set; } = new HashSet<Payment>();
    }

}
    

