using System.Data;
using OSES_DesktopClientServer.Contracts;
using OSES_DesktopClientServer.Models;
using Dapper;

namespace OSES_DesktopClientServer.Services;

public class UserService : IUserService
{
    
    private readonly IDataAccessService _dataAccess;
    //private readonly IEncryptionService _encryptionService;
    private readonly ILoggerManager _logger;
    
    public UserService(IDataAccessService dataAccess, ILoggerManager logger)
    {
        _dataAccess = dataAccess;
        _logger = logger;
    }
    
     
    public IEnumerable<User> GetAllUsers()
    {
        using (IDbConnection connection = _dataAccess.GetConnection())
        {
            var users = connection.Query<User>("GetAllUsers",CommandType.StoredProcedure);
            return users;
        }
    }

    public User? GetUserById(int id)
    {
        using (IDbConnection connection = _dataAccess.GetConnection())
        {
            var user = connection.Query<User>("GetUserById",
                 new { Id = id },
                commandType: CommandType.StoredProcedure)
                .FirstOrDefault();
            return user;
        }
    }

    public User? GetUserByEmailAndPassword(string username, string password)
    {
        using (IDbConnection connection = _dataAccess.GetConnection())
        {
            var user = connection.Query<User>("GetUserByEmailAndPassword",
                new { Email = username, Password = password },
                commandType: CommandType.StoredProcedure)
                .FirstOrDefault();
            return user;
        }
    }

    public User? AddUser(User user)
    {
        using (IDbConnection connection = _dataAccess.GetConnection())
        {
            var result = connection.Query<User>("AddUser", 
                new { user.Email, user.Password, user.FirstName, user.LastName, user.Role },
                commandType: CommandType.StoredProcedure)
                .FirstOrDefault();
            return result;
        }
    }

    public User? UpdateUser(User user)
    {
        using (IDbConnection connection = _dataAccess.GetConnection())
        {
            var result = connection.Query<User>("UpdateUser",
                new { user.Id, user.Email, user.Password, user.FirstName, user.LastName, user.Role },
                commandType: CommandType.StoredProcedure)
                .FirstOrDefault();
            return result;
        }
    }

    public User? DeleteUser(int id)
    {
        using (IDbConnection connection = _dataAccess.GetConnection())
        {
            var result = connection.Query<User>("DeleteUser",
                new { Id = id },
                commandType: CommandType.StoredProcedure)
                .FirstOrDefault();
            return result;
        }
    }
}