using firstPrjoj.Data;
using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Repository;
using SuperHeroAPI.Repository.Interfaces;
using SuperHeroAPI.Services.Contracts;
using SuperHeroAPI.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Add SuperHero services
builder.Services.AddScoped<ISuperHeroRepository, SuperHeroRepository>();
builder.Services.AddScoped<ISuperHeroServices, SuperHeroService>();

// Add SuperPower services
builder.Services.AddScoped<ISuperPowerRepository, SuperPowerRepository>();
builder.Services.AddScoped<ISuperPowerService, SuperPowerSrvice>();

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
