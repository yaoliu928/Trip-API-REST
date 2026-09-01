using Trip.API.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<ITouristRouteRepository, MockTouristRouteRepository>();

var app = builder.Build();

app.MapControllers();

app.Run();
