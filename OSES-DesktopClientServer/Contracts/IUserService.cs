using OSES_DesktopClientServer.Models;

namespace OSES_DesktopClientServer.Contracts;

public interface IUserService
{
    public IEnumerable<User> GetAllUsers();
    public User? GetUserById(int id);
    public User? GetUserByEmailAndPassword(string username, string password);
    public User? AddUser(User user);
    public User? UpdateUser(User user);
    public User? DeleteUser(int id);
}