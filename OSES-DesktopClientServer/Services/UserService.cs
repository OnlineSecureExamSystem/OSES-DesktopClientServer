using System.Data;
using AutoMapper;
using OSES_DesktopClientServer.Contracts;
using OSES_DesktopClientServer.Models;
using Dapper;
using OSES_DesktopClientServer.DataTransferObjects;
using OSES_DesktopClientServer.Models.Exceptions;

namespace OSES_DesktopClientServer.Services;

public class UserService : IUserService
{
    
    private readonly IDataAccessService _dataAccess;
    //private readonly IEncryptionService _encryptionService;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;
    
    public UserService(IDataAccessService dataAccess, ILoggerManager logger, IMapper mapper)
    {
        _dataAccess = dataAccess;
        _logger = logger;
        _mapper = mapper;
    }
 
    
     
    public IEnumerable<UserDto> GetAllUsers()
    {
        using (IDbConnection connection = _dataAccess.GetConnection())
        {
            var users = connection.Query<User>("GetAllUsers",CommandType.StoredProcedure);
            var usersDto = _mapper.Map<IEnumerable<UserDto>>(users);
            return usersDto;
        }
    }

    public UserDto? GetUserById(string id)
    {
        using (IDbConnection connection = _dataAccess.GetConnection())
        {
            var user = connection.Query<User>("GetUserById",
                 new { Id = id },
                commandType: CommandType.StoredProcedure)
                .FirstOrDefault();
            if (user is null)
                throw new UserNotFoundException(new Guid(id));
            var userDto = _mapper.Map<UserDto>(user);
            return userDto;
        }
    }

    public UserDto? GetUserByEmailAndPassword(string username, string password)
    {
        using (IDbConnection connection = _dataAccess.GetConnection())
        {
            var user = connection.Query<User>("GetUserByEmailAndPassword",
                new { Email = username, Password = password },
                commandType: CommandType.StoredProcedure)
                .FirstOrDefault();
            var userDto = _mapper.Map<UserDto>(user);
            return userDto;
        }
    }

    public UserDto? AddUser(User user)
    {
        using (IDbConnection connection = _dataAccess.GetConnection())
        {
            var result = connection.Query<User>("AddUser", 
                new { user.Email, user.Password, user.FirstName, user.LastName, user.Role },
                commandType: CommandType.StoredProcedure)
                .FirstOrDefault();
            var userDto = _mapper.Map<UserDto>(result);
            return userDto;
        }
    }

    public UserDto? UpdateUser(User user)
    {
        using (IDbConnection connection = _dataAccess.GetConnection())
        {
            var result = connection.Query<User>("UpdateUser",
                new { user.Id, user.Email, user.Password, user.FirstName, user.LastName, user.Role },
                commandType: CommandType.StoredProcedure)
                .FirstOrDefault();
            var userDto = _mapper.Map<UserDto>(result);
            return userDto;
        }
    }

    public UserDto? DeleteUser(int id)
    {
        using (IDbConnection connection = _dataAccess.GetConnection())
        {
            var result = connection.Query<User>("DeleteUser",
                new { Id = id },
                commandType: CommandType.StoredProcedure)
                .FirstOrDefault();
            var userDto = _mapper.Map<UserDto>(result);
            return userDto;
        }
    }
}