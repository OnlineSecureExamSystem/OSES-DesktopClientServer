using System.Data;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace OSES_DesktopClientServer.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{
    private readonly ILogger<HelloController> _logger;
    private readonly IConfiguration _configuration;

    public HelloController(ILogger<HelloController> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }
    
    [HttpGet(Name = "GetHello")]
    public string Get()
    {
        return "Hello World!";
    }
}