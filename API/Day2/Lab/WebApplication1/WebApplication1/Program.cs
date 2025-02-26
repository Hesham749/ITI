
using Microsoft.EntityFrameworkCore;
using WebApplication1.MapConfig;
using WebApplication1.Models;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            builder.Services.AddDbContext<ITIContext>(op =>
            op.UseLazyLoadingProxies().
            UseSqlServer(builder.Configuration.GetConnectionString("con1")));
            builder.Services.AddAutoMapper(typeof(DepartmentConfig), typeof(StudentConfig));
            string x = "";
            builder.Services.AddCors(op =>
            {
                op.AddPolicy(x,
                    builder =>
                    {
                        builder.AllowAnyOrigin();
                        builder.AllowAnyMethod();
                        builder.AllowAnyHeader();
                    }
                    );
            }

                );

            var app = builder.Build();
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwaggerUI(op => op.SwaggerEndpoint("/openApi/v1.json", "v1"));
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.UseCors(x);


            app.MapControllers();

            app.Run();
        }
    }
}
