using Application.Service;
using Contracts.Interface;
using Contracts.Interface.IService;
using Infrastructure.DataAccesses.DbContexts;
using Microsoft.EntityFrameworkCore;
using Presentation;
using Presentation.ServiceFactory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<ExampleDbContext>(opt =>
    opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"), x => x.MigrationsAssembly("Presentation")));

builder.Services.AddApplicationService();
builder.Services.AddRepositoryService();
builder.Services.AddScoped<IUserContext, UserContext>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();

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
