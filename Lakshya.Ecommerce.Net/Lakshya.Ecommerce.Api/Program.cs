using Lakshya.Ecommerce.Api.Controllers;
using Lakshya.Ecommerce.Repositories;
using Lakshya.Ecommerce.Services;
using Lakshya.Ecommerce.Services.Mappers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EcommerceDbContext>(optionsBuilder => optionsBuilder.UseSqlite(builder.Configuration.GetConnectionString("EcommerceConnection")));

builder.Services.AddScoped<ISalesService, SalesService>();
builder.Services.AddScoped<ISalesRepository, SalesRepository>();
builder.Services.AddAutoMapper(typeof(Program).Assembly, typeof(SaleProfile).Assembly);
var app = builder.Build();

using var serviceScope = app.Services.CreateScope();
var serviceProvider = serviceScope.ServiceProvider;
var dbContext = serviceProvider.GetRequiredService<EcommerceDbContext>();
dbContext.Database.EnsureCreated(); // Ensure the database is created
dbContext.SeedData(); // Invoke the SeedData method

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
