using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Data;
using Models;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;

var connectionString = "";
if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
{
    connectionString = configuration.GetConnectionString("LocalDatabase");
}
else
{
    connectionString = configuration.GetConnectionString("DefaultConnection");
}

builder.Services.AddControllers();
builder.Services.AddIdentity<User, IdentityRole<int>>()
    .AddEntityFrameworkStores<UserContext>()
    .AddDefaultTokenProviders();

builder.Services.AddDbContext<UserContext>(opt =>
    opt.UseNpgsql(connectionString));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
