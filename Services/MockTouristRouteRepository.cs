using Trip.API.Models;

namespace Trip.API.Services;

public class MockTouristRouteRepository : ITouristRouteRepository
{

  private static readonly List<TouristRoute> _routes = new List<TouristRoute>
  {
    new TouristRoute
    {
      Id = Guid.NewGuid(),
      Title = "Route 1",
      Description = "Description 1"
    },
    new TouristRoute
    {
      Id = Guid.NewGuid(),
      Title = "Route 2",
      Description = "Description 2"
    }
  };

  public IEnumerable<TouristRoute> GetTouristRoutes()
  {
    return _routes;
  }
  
  public TouristRoute GetTouristRoute(Guid touristRouteId)
  {
    // Find first route with matching ID, or return null if not found.
    return _routes.FirstOrDefault(r => r.Id == touristRouteId);
  }
}