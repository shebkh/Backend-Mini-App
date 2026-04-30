using Microsoft.AspNetCore.Mvc;

namespace Backend_Mini_App.Controllers
{
    public class Product : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
