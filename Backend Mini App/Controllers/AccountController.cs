using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    public IActionResult MyAccount()
    {
        return View();
    }
}