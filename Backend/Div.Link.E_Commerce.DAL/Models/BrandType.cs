using Div.Link.E_Commerce.DAL.Models.BaseClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Models
{
    public class BrandType :BaseEntity
    {
        public string Name { get; set; } = null!;

        public ICollection<Brand> Brands { get; set; } = new HashSet<Brand>();
    }
}
