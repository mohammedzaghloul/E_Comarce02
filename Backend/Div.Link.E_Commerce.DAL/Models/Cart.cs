using Div.Link.E_Commerce.DAL.Models.BaseClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Models
{
    public class Cart : BaseEntity
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        public ICollection<CartItem> Items { get; set; } = new HashSet<CartItem>();

    }
}
