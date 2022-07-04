using CRUDAppAMAIS.Models;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using System.Web.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//aq
//builder.Services.AddSingleton<ITempDataProvider, CookieTempDataProvider>();
//aq
builder.Services.AddSession();


builder.Services.AddDbContext<Contexto>
    (options => options.UseSqlServer("Data Source=DESKTOP-E82EH9M\\SQLEXPRESS;Initial Catalog=CRUD_AMAIS;Integrated Security=True"));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
//aqui
app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
