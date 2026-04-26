using Div.Link.E_Commerce.DAL.Models.BaseClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Models
{
    public class Seller : BaseEntity
    {
        public string? StoreName { get; set; }
        public string? Description { get; set; }

        public string ApplicationUserId { get; set; } = null!;
        public ApplicationUser ApplicationUser { get; set; } = null!;
        public decimal Total_Sales { get; set; }
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
