using Microsoft.AspNetCore.Mvc;

namespace Backend_Mini_App.Controllers
{
    public class Shop : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
