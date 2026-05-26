using MZ.Dev.Domain.Entityes;
using System.Text.Json;

namespace MZ.Dev.Repository.Data.DataSeeding
{
    public static class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext dbContext)
        {
            #region BrandData
            if (!dbContext.ProductBrands.Any())
            {
                var BrandData = File.ReadAllText("../MZ.Dev.Repository/Data/DataSeeding/brands.json");
                var Brands = JsonSerializer.Deserialize<List<ProductBrand>>(BrandData);
                if (Brands?.Count > 0)
                    foreach (var Brand in Brands)
                        await dbContext.Set<ProductBrand>().AddAsync(Brand);
                await dbContext.SaveChangesAsync();
            }
            #endregion

            #region ProductType
            if (!dbContext.ProductTypes.Any())
            {
                var ProductType = File.ReadAllText("../MZ.Dev.Repository/Data/DataSeeding/types.json");
                var Typeys = JsonSerializer.Deserialize<List<ProductType>>(ProductType);
                if (Typeys?.Count > 0)
                    foreach (var Typey in Typeys)
                        await dbContext.Set<ProductType>().AddAsync(Typey);
                await dbContext.SaveChangesAsync();
            }
            #endregion

            #region Product
            if (!dbContext.Products.Any())
            {
                var Product = File.ReadAllText("../MZ.Dev.Repository/Data/DataSeeding/products.json");
                var Products = JsonSerializer.Deserialize<List<Product>>(Product);
                if (Products?.Count > 0)
                    foreach (var product in Products)
                        await dbContext.Set<Product>().AddAsync(product);
                await dbContext.SaveChangesAsync();
            }
            #endregion

        }


    }
}
