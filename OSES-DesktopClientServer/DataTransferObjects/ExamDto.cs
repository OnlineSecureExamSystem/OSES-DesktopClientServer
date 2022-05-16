using DesktopClient.Models;
using OSES_DesktopClientServer.Models;

namespace OSES_DesktopClientServer.DataTransferObjects;

public record ExamDto
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? ExamCode { get; set; }
    public TimeSpan Duration { get; set; }
    public List<Exercise>? Exercises { get; set; }
}