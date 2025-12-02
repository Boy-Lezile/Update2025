using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;

var builder = WebApplication.CreateBuilder(args);

// Configurar o DbContext com MySQL
builder.Services.AddDbContext<SalesWebMvcContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("SalesWebMvcContext"),
        new MySqlServerVersion(new Version(8, 0, 28)) // ajuste conforme seu MySQL
    ));

// Adicionar suporte a controllers e views
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Rota padrão
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
