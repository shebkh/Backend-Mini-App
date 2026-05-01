using Microsoft.AspNetCore.Mvc;

namespace Backend_Mini_App.Controllers
{
    public class CartController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
