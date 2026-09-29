using Trip.API.Models;

namespace Trip.API.Services;

public interface ITouristRouteRepository
{
  // return a group of tourist routes
  IEnumerable<TouristRoute> GetTouristRoutes();
  // return a single tourist route by id
  TouristRoute GetTouristRoute(Guid touristRouteId);
}