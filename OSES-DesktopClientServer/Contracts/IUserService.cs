using OSES_DesktopClientServer.DataTransferObjects;
using OSES_DesktopClientServer.Models;

namespace OSES_DesktopClientServer.Contracts;

public interface IUserService
{
    public IEnumerable<UserDto> GetAllUsers();
    public UserDto? GetUserById(string id);
    public UserDto? GetUserByEmailAndPassword(string username, string password);
    public UserDto? AddUser(User user);
    public UserDto? UpdateUser(User user);
    public UserDto? DeleteUser(int id);
}