using ECommerce.Dominio.Repositorios;
using ECommerce.Infraestrutura.Data;
using ECommerce.Infraestrutura.Repositorios;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ECommerceDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));    
builder.Services.AddScoped<IOrderRepository, PedidoRepositorio>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
