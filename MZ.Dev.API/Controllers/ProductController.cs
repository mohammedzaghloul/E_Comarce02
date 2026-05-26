using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MZ.Dev.Domain.Entityes;
using MZ.Dev.Domain.Repositores;
using MZ.Dev.Domain.Specifications;
using MZ.Dev.Domain.Specifications.ProductSpec;
using MZ.Dev.Talabat.API.Dtos.ProductDto;
using MZ.Dev.Talabat.API.Errors;

namespace MZ.Dev.Talabat.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : APIBaseController
    {
        private readonly IGenericRepository<Product> _productrepo;
        private readonly IMapper mapper;
        private readonly IGenericRepository<ProductBrand> _brandRepo;
        private readonly IGenericRepository<ProductType> _typeRepo;

        public ProductController(IGenericRepository<Product> productrepo, IMapper mapper, 
            IGenericRepository<ProductBrand> brandRepo, IGenericRepository<ProductType> typeRepo)
        {
            _productrepo = productrepo;
            this.mapper = mapper;
            _brandRepo = brandRepo;
            _typeRepo = typeRepo;
        }
        [HttpGet]
        [ProducesResponseType(typeof(ProductToreturnDto), 200)]
        [ProducesResponseType(typeof(ApiResponse), 404)]

        public async Task<ActionResult<IReadOnlyList<ProductToreturnDto>>> GetProducts(string? Sort,int? BrandId,int? TypeId)
        {
            var spec = new ProductWithBrandandTypeSpec(Sort,BrandId,TypeId);
            var Products = await _productrepo.GetAllWithSpecAsync(spec);
            if (Products == null) return NotFound(new ApiResponse(404, "Products not found"));
            var mappedProducts = mapper.Map<IReadOnlyList<Product>, IReadOnlyList<ProductToreturnDto>>(Products);
            return Ok(mappedProducts);
        }

        [HttpGet("Id")]
        [ProducesResponseType(typeof(ProductToreturnDto), 200)]
        [ProducesResponseType(typeof(ApiResponse), 404)]
        public async Task<ActionResult<ProductToreturnDto>> GetProduct(int id)
        {
            var spec = new ProductWithBrandandTypeSpec(id);

            var Product = await _productrepo.GetByIdWithSpecAsync(spec);
            if (Product == null) return NotFound(new ApiResponse(404));
            var mappedProduct = mapper.Map<Product, ProductToreturnDto>(Product);
            return Ok(mappedProduct);
        }

        [HttpGet("Brands")]
        [ProducesResponseType(typeof(GetAllBrandDto), 200)]
        [ProducesResponseType(typeof(ApiResponse), 404)]

        public async Task<ActionResult<IReadOnlyList<GetAllBrandDto>>> GetBrands()
        {
            var Brands = await _brandRepo.GetAllAsync();
            return Ok(Brands);
        }
        [HttpGet("Types")]
        [ProducesResponseType(typeof(GetAllTypesDto), 200)]
        [ProducesResponseType(typeof(ApiResponse), 404)]

        public async Task<ActionResult<IReadOnlyList<GetAllTypesDto>>> GetTypes()
        {
            var Types = await _typeRepo.GetAllAsync();
            return Ok(Types);
        }
    }
}
// Sorting end video