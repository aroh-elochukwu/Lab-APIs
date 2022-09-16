using Lab_APIs.Models;
using Microsoft.EntityFrameworkCore;

#region SERVICES

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<LabApiContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("LabApiContext"));
});

var app = builder.Build();

#endregion

app.MapGet("/routes", async () => "Hello world!");







app.Run();
