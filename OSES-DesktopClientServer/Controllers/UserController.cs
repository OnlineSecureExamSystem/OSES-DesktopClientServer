using Microsoft.AspNetCore.Mvc;
using OSES_DesktopClientServer.Contracts;
using OSES_DesktopClientServer.Models;

namespace OSES_DesktopClientServer.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    
    private readonly IUserService _userService;

    public UserController(IUserService userService) => _userService = userService;
   

    [HttpGet(Name = "GetUser")]
    public IActionResult Get()
    {
        var users = _userService.GetAllUsers();
        return  Ok(users);
    }

}