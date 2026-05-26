using MZ.Dev.Domain.Entityes;

namespace MZ.Dev.Talabat.API.Dtos.ProductDto
{
    public class ProductToreturnDto
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public decimal Price { get; set; }
        public int ProductBrandId { get; set; }
        public string ProductBrand { get; set; }
        public int ProductTypeId { get; set; }
        public string ProductType { get; set; }
    }
}
