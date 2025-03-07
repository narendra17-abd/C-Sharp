using Microsoft.EntityFrameworkCore;
using Repo_Pattern.Data;
using Repo_Pattern.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


// Configure EF Core
builder.Services.AddDbContext<AppDbContext>(
options => options.UseSqlServer(builder.Configuration.GetConnectionString("lostserver")));

builder.Services.AddScoped<IProductRepository, ProductRepository>();

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
