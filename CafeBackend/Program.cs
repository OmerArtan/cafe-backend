var builder = WebApplication.CreateBuilder(args);

// 1. Controller Servisini Ekle
builder.Services.AddControllers();

// 2. CORS Güvenlik Ýznini Ekle (builder.Build'ýn ÜSTÜNDE olmalý)
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// 3. Uygulamayý Ýnþa Et (Tam olarak burada olmalý!)
var app = builder.Build();

// 4. CORS'u Aktif Et (app.Build'ýn ALTINDA olmalý)
app.UseCors();

// 5. Yönlendirme ve Yetkilendirme Ayarlarý
app.UseAuthorization();
app.MapControllers();

// 6. Projeyi Çalýþtýr
app.Run();