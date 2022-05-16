using Microsoft.AspNetCore.Mvc;
using OSES_DesktopClientServer.Contracts;

namespace OSES_DesktopClientServer.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExamController : ControllerBase
{
    private readonly IServiceManager _service;
    private readonly ILoggerManager _logger;


    public ExamController(IServiceManager service, ILoggerManager logger)
    {
        _service = service;
        _logger = logger;
    }
   
    [HttpGet]
    public IActionResult Get([FromBody] string examCode)
    {
        _logger.LogInfo("ExamController: Get()");
        return Ok(_service.ExamService.GetExam(examCode));
    }
}