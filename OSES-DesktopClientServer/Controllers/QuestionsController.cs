using Microsoft.AspNetCore.Mvc;
using OSES_DesktopClientServer.Contracts;

namespace OSES_DesktopClientServer.Controllers;

[ApiController]
[Route("api/[controller]")]
public class QuestionsController : ControllerBase
{
    private readonly ILoggerManager _logger;
    private readonly IConfiguration _configuration;

    public QuestionsController(ILoggerManager logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    [HttpGet(Name = "GetMethod")]
    public string Get()
    {
        return "Hello World!";
    }
}