#region Using
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MZ.Dev.Domain.Entityes;
using MZ.Dev.Domain.Repositores;
using MZ.Dev.Repository;
using MZ.Dev.Repository.Data;
using MZ.Dev.Repository.Data.DataSeeding;
using MZ.Dev.Talabat.API.Errors;
using MZ.Dev.Talabat.API.Hepler.Services;
using MZ.Dev.Talabat.API.Middleware;
#endregion

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<StoreContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddCollectionServices();

var app = builder.Build();
// Apply Migration
await app.MigrateAsync();
// Configure the HTTP request pipeline.
app.ConfigurePipeline();

app.Run();