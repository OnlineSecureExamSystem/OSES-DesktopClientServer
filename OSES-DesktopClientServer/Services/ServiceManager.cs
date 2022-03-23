using AutoMapper;
using OSES_DesktopClientServer.Contracts;

namespace OSES_DesktopClientServer.Services;

// This class is used to add services to the container.
public class ServiceManager : IServiceManager
{
    
    private readonly Lazy<IUserService> _userService;
    
    
    public ServiceManager(IDataAccessService dataAccessService, ILoggerManager logger, IMapper mapper)
    {
        _userService = new Lazy<IUserService>(() => new UserService(dataAccessService, logger, mapper));
    }
  
    public IUserService UserService => _userService.Value;
    
}