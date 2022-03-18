namespace OSES_DesktopClientServer.Models;

public class Exam
{
    public Guid? Id { get; set; }
    public String? Name { get; set; }
    public TimeSpan Duration { get; set; }
    public List<Question>? Questions { get; set; }
}