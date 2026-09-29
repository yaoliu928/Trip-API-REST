namespace Trip.API.Database;

using Microsoft.EntityFrameworkCore;
using Trip.API.Models;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

public class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
  public DbSet<TouristRoute> TouristRoutes { get; set; }

  public DbSet<TouristRoutePicture> TouristRoutePictures { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    // modelBuilder.Entity<TouristRoute>()
    //     .HasData(new TouristRoute
    //     {
    //         Id = Guid.Parse("6f9619ff-8b86-d011-b42d-00c04fc964ff"),
    //         Title = "test title",
    //         Description = "This is a sample description for the tourist route.",
    //         OriginalPrice = 0,
    //         CreateTime = new DateTime(
    //             2026, 9, 20, 0, 0, 0,
    //             DateTimeKind.Utc)
    //     });

            var touristRouteJsonData = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"/Database/touristRoutesMockData.json");
            IList<TouristRoute> touristRoutes = JsonConvert.DeserializeObject<IList<TouristRoute>>(touristRouteJsonData);
            modelBuilder.Entity<TouristRoute>().HasData(touristRoutes);

            var touristRoutePictureJsonData = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"/Database/touristRoutePicturesMockData.json");
            IList<TouristRoutePicture> touristRoutePictures = JsonConvert.DeserializeObject<IList<TouristRoutePicture>>(touristRoutePictureJsonData);
            modelBuilder.Entity<TouristRoutePicture>().HasData(touristRoutePictures);
    base.OnModelCreating(modelBuilder);
}
}