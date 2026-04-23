using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Models
{
    public class Cart : BaseEntity
    {
        public int CustomerId { get; set; }//foreign key to the customer table
        public Customer Customer { get; set; }
        public int ProductsId { get; set; }//foreign key to the product table
        public Product Product { get; set; }
        public float GrandTotal { get; set; }
        public int ItemTotal { get; set; }
        public ICollection<ProductCart> ProductCarts { get; set; } = new HashSet<ProductCart>();
    }
}
