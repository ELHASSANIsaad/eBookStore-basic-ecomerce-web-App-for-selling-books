using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BooksStore.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BooksStoreContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BooksStoreContext") ?? throw new InvalidOperationException("Connection string 'BooksStoreContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession(options => { options.IdleTimeout = TimeSpan.FromMinutes(1); });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    //pattern: "{controller=Home}/{action=Index}/{id?}");
    pattern: "{controller=usersaccounts}/{action=login}/{id?}");

app.Run();
