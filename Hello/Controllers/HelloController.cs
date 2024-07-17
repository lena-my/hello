using Microsoft.AspNetCore.Mvc;

namespace Hello.Controllers;

public class HelloController : Controller
{
    // GET
    public IActionResult YellHello()
    {
        return View();
    }

    [Route("/Hello/SayHello")]
    public IActionResult SayHello()
    {
        return View();
    }
}