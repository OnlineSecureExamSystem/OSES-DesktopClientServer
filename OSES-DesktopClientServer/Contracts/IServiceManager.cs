namespace OSES_DesktopClientServer.Contracts;

public interface IServiceManager 
{
     IUserService UserService { get; }
     IExamService ExamService { get; }
}