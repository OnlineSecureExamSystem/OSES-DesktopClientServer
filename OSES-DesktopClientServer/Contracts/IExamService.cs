using OSES_DesktopClientServer.DataTransferObjects;

namespace OSES_DesktopClientServer.Contracts;

public interface IExamService
{
    public ExamDto? GetExam(string examCode);
}