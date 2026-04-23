using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Models
{
    public class Seller : BaseEntity
    {
        public string ApplicationUserId { get; set; } = null!;
        public ApplicationUser ApplicationUser { get; set; } = null!;
        public decimal Total_Sales { get; set; }
        public ICollection<ProductSeller> ProductSellers { get; set; } = new List<ProductSeller>();

    }
}
