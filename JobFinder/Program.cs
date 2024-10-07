using JobFinder.DataAccess;
using JobFinder.Model.Utils;
using JobFinder.Service;

var builder = WebApplication.CreateBuilder(args);
// Add app settings
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection(AppSettings.AppSetting));
// Add services to the container.
builder.Services.AddControllers();
//Injection Dependency
builder.Services.AddDatabaseAccess();
builder.Services.AddService();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
