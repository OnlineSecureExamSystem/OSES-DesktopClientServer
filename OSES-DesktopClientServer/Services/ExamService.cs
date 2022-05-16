using AutoMapper;
using OSES_DesktopClientServer.Contracts;
using OSES_DesktopClientServer.DataTransferObjects;
using OSES_DesktopClientServer.Models;
using static Newtonsoft.Json.JsonConvert;

namespace OSES_DesktopClientServer.Services;

public class ExamService : IExamService
{
    
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    
    public ExamService(ILoggerManager logger, IMapper mapper)
    {
        _logger = logger;
        _mapper = mapper;
    }
    
    public ExamDto? GetExam(string examCode)
    {
        if (examCode == "AAAAAA")
        {
            var json = File.ReadAllText(
                "C:\\Users\\rd07g\\Desktop\\OSES\\Server-asp-net-api\\OSES-DesktopClientServer\\Models\\ExperimentalData\\Exam.json");
            var result = DeserializeObject<ExamDto>(json);
            return result;
        }
        return null;
    }
}