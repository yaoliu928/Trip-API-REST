namespace Trip.API.Database;

using Microsoft.EntityFrameworkCore;
using Trip.API.Models;

public class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
  public DbSet<TouristRoute> TouristRoutes { get; set; }

  public DbSet<TouristRoutePicture> TouristRoutePictures { get; set; }
}