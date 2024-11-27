using EntityFrameworkDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//read connection string from appsetting.json file
var configuration = builder.Configuration.GetConnectionString("DefaultConnection");

//pass connection string to ApplicatiobDbContext class
builder.Services.AddDbContext<ApplicatiobDbContext>(options=> options.UseSqlServer(configuration));

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
