using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc(option => option.EnableEndpointRouting = false);
builder.Services.AddSession();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                    .AddCookie(options =>
                    {
                        options.LoginPath = "/Medecin/Index";
                        options.LogoutPath = "/Medecin/SignOut";
                        options.AccessDeniedPath = "/Medecin/AccessDenied";
                    });

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseRouting();
app.UseAuthentication();

app.UseStaticFiles();
app.UseAuthorization();
app.UseSession();
app.UseMvc(routes => routes.MapRoute("Default", "{controller=Medecin}/{action=Index}/{id?}"));
app.Run();
