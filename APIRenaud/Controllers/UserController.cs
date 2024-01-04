
using Microsoft.AspNetCore.Mvc;

namespace APIRenaud.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : Controller
{
    [HttpGet]
    [Route("{id}")]
    public IActionResult GetByClientID(int id)
    {
        return Ok();
    }
}