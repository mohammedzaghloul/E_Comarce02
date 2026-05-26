using Microsoft.EntityFrameworkCore;
using MZ.Dev.Repository.Data;
using MZ.Dev.Repository.Data.DataSeeding;
using MZ.Dev.Talabat.API.Hepler.Services;

namespace MZ.Dev.Talabat.API.Hepler.Services
{
    public static class Migrate
    {
        public static async Task MigrateAsync(this WebApplication app)
        {
            var scpoed = app.Services.CreateScope();
            var services = scpoed.ServiceProvider;
            var LoggerFactory = services.GetRequiredService<ILoggerFactory>();
            try
            {
                var dbContext = services.GetRequiredService<StoreContext>();
                await dbContext.Database.MigrateAsync();
                Console.WriteLine("Migrate");
                await StoreContextSeed.SeedAsync(dbContext);
                scpoed.Dispose();
            }
            catch (Exception ex)
            {
                var logger = LoggerFactory.CreateLogger<Program>();
                logger.LogError(ex, "An Error Occured During Appling The Migration");
            }
        }
    }
}
