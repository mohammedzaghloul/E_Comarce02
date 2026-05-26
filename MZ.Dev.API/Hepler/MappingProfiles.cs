using AutoMapper;
using MZ.Dev.Domain.Entityes;
using MZ.Dev.Talabat.API.Dtos.ProductDto;

namespace MZ.Dev.Talabat.API.Hepler
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles() {
            CreateMap<Product, ProductToreturnDto>()
            .ForMember(d => d.ProductBrand, o => o.MapFrom(s => s.ProductBrand.Name))
            .ForMember(d => d.ProductType, o => o.MapFrom(s => s.ProductType.Name))
            .ForMember(d => d.PictureUrl, o => o.MapFrom<ProductPictureURLResolver>());    
            CreateMap<ProductBrand, GetAllBrandDto>();
            CreateMap<ProductType, GetAllTypesDto>();   
        }
    }
}
