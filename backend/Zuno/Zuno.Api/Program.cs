using Zuno.Application.Interfaces;
using Zuno.Application.Services;
using Zuno.Infrastructure.Repositories;
using Zuno.Application.Services;
using Zuno.Infrastructure.Persistance;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddScoped<IUserRepository, UserRepository>();
//builder.Services.AddScoped<IUserService, UserService>();
//builder.Services.AddDbContext<ZunoDbContext>;

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
