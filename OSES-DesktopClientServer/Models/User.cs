namespace OSES_DesktopClientServer.Models;

public class User
{
    public string Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
  
    public string Role { get; set; }
    public string CreatedDate { get; set; }
    public string UpdatedDate { get; set; }
    
}