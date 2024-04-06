using System.Reflection;

using ApiMediaRDemo.Infrastructure.Data;
using ApiMediaRDemo.Infrastructure.Repositories;
using ApiMediaRDemo.Infrastructure.Validators;
using ApiMediaRDemo.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

// Validator
builder.Services.AddScoped<IValidator<PersonInput>, PersonValidator>();

// Repository Registration
builder.Services.AddScoped<IPersonRepository, PersonRepository>();

// MediatR setup
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

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
