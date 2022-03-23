using Microsoft.AspNetCore.Mvc;
using OSES_DesktopClientServer.Contracts;
using OSES_DesktopClientServer.Models;

namespace OSES_DesktopClientServer.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IServiceManager _service;

    public UserController(IServiceManager service) => _service = service;


    [HttpGet]
    public IActionResult Get()
    {
        try
        {
            var users = _service.UserService.GetAllUsers();
            return Ok(users);
        }
        catch (Exception e)
        {
            return StatusCode(500, "Internal server error \n" + e);
        }
    }
}