using Microsoft.AspNetCore.Mvc;
using OSES_DesktopClientServer.Contracts;

namespace OSES_DesktopClientServer.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExamsController : ControllerBase
{
    private readonly ILoggerManager _logger;
    private readonly IConfiguration _configuration;
    public ExamsController(ILoggerManager logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    [HttpGet(Name = "GetExams")]
    public ActionResult<string> Get()
    {
        _logger.LogInfo("Here is info message from the controller.");
        return "This is an exam";
    }
    
}