using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public abstract class MyFirstAPIBaseController : ControllerBase
{
    public string Author { get; set; } = "Wellison Asley";

    [HttpGet("heathy")]
    public IActionResult Heathy()
    {
        return Ok("It's work!");
    }

    protected string GetCustomerKey()
    {
        return Request.Headers["MyKey"].ToString();
    }
}
