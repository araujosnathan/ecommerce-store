using AutoMapper;
using ECommerce.API.Config;
using ECommerce.API.Model.Context;
using ECommerce.API.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add Databse Context
var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
var connectionString = config.GetValue<string>("MySQlConnectionString");

builder.Services.AddDbContext<MySQLContext>(x => x.UseMySql(connectionString, new MySqlServerVersion(
                            new Version(8, 0, 30))));


// Add Mapper
IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Add Repository
builder.Services.AddScoped<IProductRepository, ProductRepository>();

// Add services to the container.
builder.Services.AddControllers();
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



