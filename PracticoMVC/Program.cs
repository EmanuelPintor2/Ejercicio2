using Microsoft.EntityFrameworkCore;
using PracticoMVC.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=productos.db"));//archivo fisico, por lo tanto es persistente la BD


var app = builder.Build();

//bloque para proteger app en produccion, mientras que en desarrollo se omite para facilitar depuracion
if (!app.Environment.IsDevelopment())//comprobacion de entorno
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

//middlewares, http a https y enrutamiento de ASP.NET Core
app.UseHttpsRedirection();
app.UseRouting();


app.UseAuthorization();

app.MapStaticAssets();

//Registra ruta para MVC. Activa endpoints de controladores
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")//patron de la URL
    .WithStaticAssets();


app.Run();
