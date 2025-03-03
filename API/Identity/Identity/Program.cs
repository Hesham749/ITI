using System.Text;
using Identity.Data;
using Identity.Model;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#region add context service

builder.Services.AddDbContext<AppDbContext>(op => op.UseSqlServer("Data Source=.;Initial Catalog=JwtTest1;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"));

#endregion

#region add identity service 

builder.Services.AddIdentity<AppUser, IdentityRole>(op =>
{
    op.Password.RequiredLength = 6;
}).AddEntityFrameworkStores<AppDbContext>();

#endregion

#region add authentication and jwt services
builder.Services.AddAuthentication(op =>
op.DefaultAuthenticateScheme =
op.DefaultChallengeScheme =
op.DefaultSignInScheme =
op.DefaultSignOutScheme =
op.DefaultForbidScheme = JwtBearerDefaults.AuthenticationScheme
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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
