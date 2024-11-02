using Art.Web.Middlewares;
using JobFinder.DataAccess;
using JobFinder.Model.Utils;
using JobFinder.Middlewares;
using JobFinder.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using JobFinder.Model.Utils.Constants;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

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
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Art's API", Version = "v1" });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                },
                Scheme = "oauth2",
                Name = "Bearer",
                In = ParameterLocation.Header,
            },
            new List<string>()
        }
    });
});
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
            ValidateAudience = false,
        };
        opt.Events = new JwtBearerEvents()
        {
            OnMessageReceived = context =>
            {
                var contextToken = context.Request.Cookies[Authentication.JwtCookieKey];
                if (!string.IsNullOrEmpty(contextToken))
                {
                    context.Token = contextToken;
                }

                return Task.CompletedTask;
            }
        };
    });
//CORS
string AllowAllCorsPolicy = "AllowAllCorsPolicy";
string AllowOnlyClientCorsPolicy = "AllowOnlyClientCorsPolicy";
builder.Services.AddCors(opt =>
{
    opt.AddPolicy(AllowAllCorsPolicy,
        builder => builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials());
});
builder.Services.AddCors(opt =>
{
    opt.AddPolicy(AllowOnlyClientCorsPolicy,
        builder => builder
            .WithOrigins(appSettings?.Value.ClientUrl)
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials());
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(AllowOnlyClientCorsPolicy);

app.UseAuthentication();
app.UseAuthorization();

//middlewares
app.UseMiddleware<TransactionMiddleware>();
app.UseMiddleware<ExceptionHandlingMiddleware>();


app.MapControllers();

app.Run();
