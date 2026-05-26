using MZ.Dev.Talabat.API.Middleware;

namespace MZ.Dev.Talabat.API.Hepler.Services
{
    public static class Pipeline
    {
        public static WebApplication ConfigurePipeline(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseMiddleware<ExceptionMiddleware>();
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseStaticFiles();
            //app.UseHttpsRedirection();
            app.UseStatusCodePagesWithReExecute("/Errors/{0}");
            app.UseAuthorization();
            app.MapControllers();
            return app;
        }
    }
}
