using Microsoft.AspNetCore.Mvc;
namespace Trip.API.Properties.Controllers;


[Route("api/manualapi")]
public class ManualAPIController: ControllerBase
{
   [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

};
