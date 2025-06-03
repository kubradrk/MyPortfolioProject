using Microsoft.EntityFrameworkCore;
using PortfolyoSitem.Data; // kendi namespace’ine göre değiştir

var builder = WebApplication.CreateBuilder(args);

// 1️⃣ Veritabanı bağlantısını ekle (EF Core)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2️⃣ MVC servisini ekle
builder.Services.AddControllersWithViews();

var app = builder.Build();

// 3️⃣ Pipeline ayarları
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// 4️⃣ Varsayılan route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
