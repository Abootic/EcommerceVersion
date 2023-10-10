using Autofac;
using Autofac.Extensions.DependencyInjection;
using EcommereceWeb.Infrstraction.Extensions;
using EcommereceWeb.Application.Extensions;
using EcommereceWeb.Application.Interfaces.Common;
using EcommereceWeb.MVC.Services;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();
var configration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
builder.Services.ApplicationServices();
builder.Services.AddPresistence(configration);


builder.Services.AddScoped<ICurrentUserServices, CurrentUserServices>();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new EcommereceWeb.Application.DI.MainModule());
    builder.RegisterModule(new EcommereceWeb.Infrstraction.DI.MainModule());
    
});
builder.Services.ConfigureApplicationCookie(builder =>
{
    builder.LoginPath = "/UserAccess/Login";
    builder.LoginPath = "/UserAccess/Logout";
    builder.AccessDeniedPath = "/Account/AccessDenaid";
    builder.SlidingExpiration = true;

});
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<IUplaodFileService, UplaodFileService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseStaticFiles();

app.UseAuthentication();
app.UseRouting();
app.UseCookiePolicy();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
