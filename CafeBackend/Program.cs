using CafeBackend.Models;
using Microsoft.EntityFrameworkCore;
using CafeBackend.Data; // Bunu ekliyoruz

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
}); builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 1. Veritabaný baðlantýmýzý sisteme tanýtýyoruz
builder.Services.AddDbContext<CafeDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. React (Frontend) uygulamasýnýn API'ye istek atabilmesi için CORS politikasý ekliyoruz
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp",
        policy =>
        {
            // Þimdilik geliþtirme aþamasýnda her þeye izin veriyoruz (Canlýda buraya sadece React'in adresini yazacaðýz)
            policy.AllowAnyOrigin()
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// CORS politikasýný devreye alýyoruz (UseAuthorization'dan önce olmalý)
app.UseCors("AllowReactApp");

app.UseAuthorization();

app.MapControllers();

app.Run();