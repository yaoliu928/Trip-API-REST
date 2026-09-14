using Trip.API.Database;
using Trip.API.Models;

namespace Trip.API.Services;

public class TouristRouteRepository : ITouristRouteRepository
{
  private readonly AppDbContext _context;

  public TouristRouteRepository( AppDbContext context)
  {
    _context = context;
  }

  public TouristRoute GetTouristRoute(Guid touristRouteId)
  {
    return _context.TouristRoutes.FirstOrDefault(tr => tr.Id == touristRouteId);
  }

  public IEnumerable<TouristRoute> GetTouristRoutes()
  {
    return _context.TouristRoutes;
  }
}