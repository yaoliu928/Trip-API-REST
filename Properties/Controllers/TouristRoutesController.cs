using Microsoft.AspNetCore.Mvc;
using Trip.API.Services;

namespace Trip.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TouristRoutesController: ControllerBase
{
  private ITouristRouteRepository _touristRouteRepository;

  public TouristRoutesController(ITouristRouteRepository touristRouteRepository)
  {
    // Assign the injected repository to the private field.
    // i.e., initialize the controller with the repository instance
    _touristRouteRepository = touristRouteRepository;
  }

  public IActionResult GetTouristRoutes()
  {
    var touristRoutes = _touristRouteRepository.GetTouristRoutes();
    return Ok(touristRoutes);
  }
}