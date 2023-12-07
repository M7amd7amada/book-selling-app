using Microsoft.AspNetCore.Mvc;

namespace BookSelling.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestingController : ControllerBase
{
    [HttpGet(template: "testone", Name = "testerOne")]
    public IActionResult GetTestOne()
    {
        return Ok("Hello, World! TEST");
    }

    [HttpGet(Name = "testerTwo")]
    public IActionResult GetTestTwo()
    {
        return Ok("Hello, World! TEST");
    }
}