using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers;

public class DeviceController : MyFirstAPIBaseController
{
    [HttpGet]
    public IActionResult GetDevice()
    {
        var key = GetCustomerKey();

        return Ok(key);
    }
}
