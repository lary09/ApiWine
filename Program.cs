using APIWine.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
using NuGet.Protocol.Plugins;
using System.Diagnostics.Metrics;
=======
>>>>>>> 1d86b380fcc9b0fb51dfe78e6778d15de95131c6
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

<<<<<<< HEAD
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer("Server=DESKTOP-I0TRJDL\\SQLEXPRESS01;Database=wine;User ID=sa;Password=12345678;TrustServerCertificate=true;");
=======

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer("Server=DESKTOP-I0TRJDL\\SQLEXPRESS;Database=wine;TrustServerCertificate=true;ConnectRetryCount=3;ConnectRetryInterval=5;");
>>>>>>> 1d86b380fcc9b0fb51dfe78e6778d15de95131c6
});



<<<<<<< HEAD

=======
>>>>>>> 1d86b380fcc9b0fb51dfe78e6778d15de95131c6
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
