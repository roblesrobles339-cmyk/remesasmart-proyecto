using Microsoft.EntityFrameworkCore;
using RemesaSmart.Api.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("ReactPolicy", policy =>
    {
        policy.WithOrigins("http://localhost:5173")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Registro del DbContext para PostgreSQL
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection") ?? 
    "Server=localhost;Port=5432;Database=remesasmart_db;User Id=postgres;Password=postgres;"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // app.MapOpenApi(); // Comentado temporalmente si no se usa OpenAPI/.NET 8 genérico
}


app.UseHttpsRedirection();

app.UseHttpsRedirection();

app.UseCors("ReactPolicy");

app.UseAuthorization();

app.UseAuthorization();

app.MapControllers();

app.Run();