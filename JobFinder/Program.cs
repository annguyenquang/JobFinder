using Art.Web.Middlewares;
using JobFinder.DataAccess;
using JobFinder.Model.Utils;
using JobFinder.Middlewares;
using JobFinder.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
// Add app settings
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection(AppSettings.AppSetting));
var appSettings = builder.Services.BuildServiceProvider().GetService<IOptions<AppSettings>>();
// Add services to the container.
builder.Services.AddControllers();
//Injection Dependency
builder.Services.AddDatabaseAccess();
builder.Services.AddService();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Authentication
builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(opt =>
    {
        opt.RequireHttpsMetadata = false;
        opt.SaveToken = false;
        opt.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(appSettings?.Value.JwtSecretKey)),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });

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

//middlewares
app.UseMiddleware<TransactionMiddleware>();
app.UseMiddleware<ExceptionHandlingMiddleware>();


app.Run();
