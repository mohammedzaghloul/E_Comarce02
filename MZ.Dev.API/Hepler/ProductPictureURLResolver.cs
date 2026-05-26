using AutoMapper;
using MZ.Dev.Domain.Entityes;
using MZ.Dev.Talabat.API.Dtos.ProductDto;

namespace MZ.Dev.Talabat.API.Hepler
{
    public class ProductPictureURLResolver : IValueResolver<Product, ProductToreturnDto, string>
    {
        private readonly IConfiguration configuration;

        public ProductPictureURLResolver(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public string Resolve(Product source, ProductToreturnDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.PictureUrl))
            {
                return $"{configuration["APIBASEURL"]}{source.PictureUrl}";
            }
            return string.Empty;
        
        }
    }
}
