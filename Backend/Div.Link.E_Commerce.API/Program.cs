using Div.Link.E_Commerce.DAL.Data;
using Div.Link.E_Commerce.DAL.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();


using (var scope = app.Services.CreateScope()){
    var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

    if (!context.Categories.Any())
    {
        var parent = new Category
        {
            Name = "Electronics",
            Description = "All kinds of electronic devices"
        };

        var child = new Category
        {
            Name = "Mobile Phones",
            Description = "Smartphones and related accessories",
            ParentCategory = parent
        };

        context.Categories.AddRange(parent, child);
        context.SaveChanges();
    }
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll"); 

app.UseAuthorization();

app.MapControllers();

app.Run();