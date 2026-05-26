using Microsoft.AspNetCore.Mvc;
using MZ.Dev.Domain.Repositores;
using MZ.Dev.Repository;
using MZ.Dev.Talabat.API.Errors;

namespace MZ.Dev.Talabat.API.Hepler.Services
{
    public static class CollectionServices
    {
         public static IServiceCollection AddCollectionServices(this IServiceCollection services)
         {
            services.AddControllers();

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));


            services.AddAutoMapper(typeof(MappingProfiles));

            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.InvalidModelStateResponseFactory = (actionContext) =>
                {
                    var errors = actionContext.ModelState
                        .Where(e => e.Value.Errors.Count > 0)
                        .SelectMany(x => x.Value.Errors)
                        .Select(x => x.ErrorMessage).ToArray();
                    var errorResponse = new ApiValiadtionErrorRespose
                    {
                        Errors = errors
                    };
                    return new BadRequestObjectResult(errorResponse);
                };
            });

            return services;
         }
    }
}
