using Microsoft.AspNetCore.Mvc;
namespace Web.API.Controlllers
{
    [Route("api/v1/camps")]
    public class CampsController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok( new {Name="Esteban", FavoriteColor="Blue"});

        }
        

    }
}