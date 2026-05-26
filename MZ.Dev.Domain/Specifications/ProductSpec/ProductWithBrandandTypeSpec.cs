using MZ.Dev.Domain.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MZ.Dev.Domain.Specifications.ProductSpec
{
    public class ProductWithBrandandTypeSpec:BaseSpecification<Product>
    {
        public ProductWithBrandandTypeSpec(string? Sort,int? BrandId,int? TypeId)
            :base(p=>
            (!BrandId.HasValue || p.ProductBrandId == BrandId) 
            &&
            (!TypeId.HasValue || p.ProductTypeId == TypeId))
        {
            Includes.Add(a => a.ProductBrand);

            Includes.Add(a => a.ProductType);
            if (!string.IsNullOrEmpty(Sort))
            {
                switch (Sort)
                {
                    case "PriceAsc":
                        AddOrderBy(a => a.Price);
                        break;
                    case "PriceDesc":
                        AddOrderByDescending(a => a.Price);
                        break;
                    default:
                        AddOrderBy(a => a.Name);
                        break;
                }
            }
             else
             {
                AddOrderBy(a => a.Name);
             }
        }
        public ProductWithBrandandTypeSpec(int id):base(a=>a.Id==id)
        {
            Includes.Add(a => a.ProductBrand);

            Includes.Add(a => a.ProductType);

        }
    }
}
