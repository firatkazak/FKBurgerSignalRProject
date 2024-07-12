using FKBurger.DataAccess.Concrete;
using FKBurger.Entity.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

var requireAuthorizePolicy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();

builder.Services.AddDbContext<FKBurgerDBContext>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<FKBurgerDBContext>();
builder.Services.AddHttpClient();
builder.Services.AddControllersWithViews(opt =>
{
    opt.Filters.Add(new AuthorizeFilter(requireAuthorizePolicy));
});

builder.Services.ConfigureApplicationCookie(opts =>
{
    opts.LoginPath = "/Login/Index/";
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler();//"/Home/Error"
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(name: "default", pattern: "{controller=Default}/{action=Index}/{id?}");

app.Run();
