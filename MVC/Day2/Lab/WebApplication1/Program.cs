using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models.Services;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            #region Dependency injection
            builder.Services.AddSession(s =>
            {

            });
            builder.Services.AddScoped<IDepartmentService, DepartmentService>();
            builder.Services.AddScoped<IStudentService, StudentService>();
            builder.Services.AddDbContext<ITIZagContext>(e =>
            {
                e.UseSqlServer(builder.Configuration.GetConnectionString("con1"));
            })
            ;
            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
               .AddCookie(options =>
               {
                   options.LoginPath = "/Account/Login";
                   options.LogoutPath = "/Account/Logout";
                   //options.Cookie.SecurePolicy = CookieSecurePolicy.Always; //  Secure
                   //options.Cookie.SameSite = SameSiteMode.Strict; //  SameSite
               });
            #endregion

            var app = builder.Build();

            #region Custom middleware

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("middle ware 1");
            //    await next.invoke();
            //    await context.Response.WriteAsync("middle ware 1 continue");
            //});

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("terminate");
            //});

            #endregion

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
                pattern: "{controller=student}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
