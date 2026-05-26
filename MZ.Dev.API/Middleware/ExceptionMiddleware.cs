using MZ.Dev.Talabat.API.Errors;
using System.Net;
using System.Text.Json;

namespace MZ.Dev.Talabat.API.Middleware
{
    //500 Internal Server Error
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger<ExceptionMiddleware> logger;
        private readonly IHostEnvironment env;

        public ExceptionMiddleware(RequestDelegate Next,ILogger<ExceptionMiddleware> logger,IHostEnvironment env)
        {
            next = Next;
            this.logger = logger;
            this.env = env;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                //await next.Invoke(context);
                await next(context);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                //if(env.IsDevelopment())
                //{
                //  var response =new ApiExceptionResponse(context.Response.StatusCode, ex.Message, ex.StackTrace?.ToString());
                //}
                //var response = new ApiExceptionResponse(500);
                var response = env.IsDevelopment() ? new ApiExceptionResponse(context.Response.StatusCode, ex.Message, ex.StackTrace?.ToString()): new ApiExceptionResponse(context.Response.StatusCode);

                var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
                var json = JsonSerializer.Serialize(response, options);
                await context.Response.WriteAsync(json);
            }
        }
    }
}
