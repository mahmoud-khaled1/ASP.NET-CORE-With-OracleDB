using CoreCRUDWithOracle.Interfaces;
using CoreCRUDWithOracle.Models;
using CoreCRUDWithOracle.Services;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddTransient<IStudentService, StudentService>();
builder.Services.AddDbContext<ModelContext>(options =>
       options.UseOracle(builder.Configuration.GetConnectionString("OracleDbConnection")));

//builder.Services.AddDbContext<ModelContext>();
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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
