using AeC_API.NET.Interfaces;
using AeC_API.NET.Repositories;
using AeC_API.NET.Repositories.Entities;
using AeC_API.NET.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

Perfil.ConnectionStrings = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<Contexto>(options => options.UseSqlServer(Perfil.ConnectionStrings));
builder.Services.AddScoped<IIntegracaoBrasilAPI, IntegracaoBrasilAPI>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
