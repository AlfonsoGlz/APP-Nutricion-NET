using APP_Nutricion.Models;
using APP_Nutricion.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<APP_NutricionContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionApp")));
builder.Services.AddScoped<IAlimentosService, AlimentosService>();
builder.Services.AddScoped<IUnidadService, UnidadService>();
builder.Services.AddScoped<ICategoriaService, CategoriaService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Alimentos}/{action=Index}/{id?}");

app.Run();
