using Art.Web.Middlewares;
using JobFinder.DataAccess;
using JobFinder.Middlewares;
using JobFinder.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

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

//middlewares
app.UseMiddleware<TransactionMiddleware>();
app.UseMiddleware<ExceptionHandlingMiddleware>();


app.Run();
