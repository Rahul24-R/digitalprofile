using Digitalprofile.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>( opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});    //adding the DBcontext as a service , with sql lite and getting the connection string
       // from configuration with name "DefaultConnection"
builder.Services.AddCors();

var app = builder.Build();
app.UseCors(x=>x.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod());
// Configure the HTTP request pipeline.

app.MapControllers();

app.Run();
