using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IService<Department>, DepartmentService>();
            builder.Services.AddScoped<IService<Student>, StudentService>();
            builder.Services.AddDbContext<ITIZagContext>(e =>
            {
                e.UseSqlServer(builder.Configuration.GetConnectionString("con1"));
            })
            ;

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
                pattern: "{controller=student}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
