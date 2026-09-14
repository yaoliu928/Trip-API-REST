using Trip.API.Services;
using Microsoft.EntityFrameworkCore;
using Trip.API.Database;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<ITouristRouteRepository, TouristRouteRepository>();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration["ConnectionStrings:DefaultConnection"])
); 

var app = builder.Build();

app.MapControllers();

app.Run();
