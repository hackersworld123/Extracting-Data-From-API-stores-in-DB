using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using product_catalog_managements.Api.Data;
using product_catalog_managements.Api.Services;
using product_catalog_managements.Api.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEntityFrameworkMySql();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ProductDbContext>(
    o =>
    {
        o.UseMySql(builder.Configuration.GetConnectionString("productcatalogmanagement"), new MySqlServerVersion(new Version()));
    });
builder.Services.AddTransient<IProductServices, ProductServices>();
builder.Services.AddTransient<IInvoiceServices, InvoiceServices>();
builder.Services.AddTransient<IProductCategoryServices, ProductCategoryServices>();
var app = builder.Build();

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
