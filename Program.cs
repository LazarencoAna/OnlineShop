using OnlineShop.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using AutoMapper.EquivalencyExpression;
using OnlineShop.BAL.Services.Products;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ShopDbContext>(o => o.UseSqlite($"Data Source=OnlineShop.db"));

builder.Services.AddCors(options =>
{
    options.AddPolicy("cors",
       policy =>
             {
                 policy.AllowAnyOrigin()
                       .AllowAnyHeader()
                       .AllowAnyMethod();
             });
});

builder.Services.AddAutoMapper(config => config.AddCollectionMappers(), Assembly.GetExecutingAssembly());
builder.Services.AddTransient<IProductsServices, ProductsServices>();

var app = builder.Build();

app.UseCors("cors");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();

app.Run();
