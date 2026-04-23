using Div.Link.E_Commerce.DAL.Models.BaseClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Models
{
    public class Brand :BaseEntity
    {
        public string Name { get; set; } = null!;

        public int BrandTypeId { get; set; }
        public BrandType BrandType { get; set; } = null!;

        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
