using Microsoft.AspNetCore.Mvc;

namespace Trip.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestAPIController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
