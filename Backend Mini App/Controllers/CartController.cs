using Microsoft.AspNetCore.Mvc;

namespace Backend_Mini_App.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
