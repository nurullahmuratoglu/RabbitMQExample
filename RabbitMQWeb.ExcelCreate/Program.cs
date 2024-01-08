using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RabbitMQ.Client;
using RabbitMQWeb.ExcelCreate.Models;
using RabbitMQWeb.ExcelCreate.Services;

var builder = WebApplication.CreateBuilder(args);






builder.Services.AddDbContext<AppDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"));

});
builder.Services.AddSingleton(sp => new ConnectionFactory() { Uri = new Uri(builder.Configuration.GetConnectionString("RabbitMQURL")), DispatchConsumersAsync = true });

builder.Services.AddSingleton<RabbitMQClientService>();
builder.Services.AddSingleton<RabbitMQPublisher>();
builder.Services.AddIdentity<IdentityUser, IdentityRole>(opt =>
{
    opt.User.RequireUniqueEmail = true;

}).AddEntityFrameworkStores<AppDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
