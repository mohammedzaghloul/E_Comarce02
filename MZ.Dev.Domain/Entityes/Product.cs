using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MZ.Dev.Domain.Entityes
{
    public class Product:ModelBase
    {
        public string Name { get; set; }=null!;
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public decimal Price { get; set; }
        public int ProductBrandId { get; set; }
        public ProductBrand ProductBrand { get; set; }
        public int ProductTypeId { get; set; } 
        public ProductType ProductType { get; set; }
    }
}
