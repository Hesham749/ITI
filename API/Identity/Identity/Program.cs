using System.Text;
using Identity.Data;
using Identity.Interfaces;
using Identity.Model;
using Identity.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "Demo API", Version = "v1" });
    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter a valid token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });
    option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });
});
builder.Services.AddScoped<ITokenService, TokenService>();
#region add context service

builder.Services.AddDbContext<AppDbContext>(op => op.UseSqlServer("Data Source=.;Initial Catalog=JwtTest1;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"));

#endregion

#region add identity service 

builder.Services.AddIdentity<AppUser, IdentityRole>(op =>
{
    op.Password.RequiredLength = 6;
    op.Password.RequiredUniqueChars = 0;
    op.Password.RequireUppercase = false;
    op.User.RequireUniqueEmail = true;
}).AddEntityFrameworkStores<AppDbContext>();

#endregion

#region add authentication and jwt services
builder.Services.AddAuthentication(op =>
op.DefaultAuthenticateScheme =
op.DefaultChallengeScheme =
op.DefaultSignInScheme =
op.DefaultSignOutScheme =
op.DefaultForbidScheme =
op.DefaultScheme = JwtBearerDefaults.AuthenticationScheme
).AddJwtBearer(
op =>
{
    op.TokenValidationParameters = new()
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
        ValidateLifetime = true,
    };
});
#endregion


var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
