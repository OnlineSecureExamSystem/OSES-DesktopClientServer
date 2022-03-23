using Microsoft.AspNetCore.Mvc;
using OSES_DesktopClientServer.Contracts;
using OSES_DesktopClientServer.Models;
using OSES_DesktopClientServer.Models.Exceptions;

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
        var users = _service.UserService.GetAllUsers();
        return Ok(users);
    }
}