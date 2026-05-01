using Microsoft.AspNetCore.Mvc;

public class AccountController : ControllerBase
{
    public IActionResult MyAccount()
    {
        return Ok();
    }
}