namespace OSES_DesktopClientServer.DataTransferObjects;


public record UserDto
{
    public string? Id { get; init; }
    public string? FullName { get; init; }
    public string? Email { get; init; } 
    public string? Phone { get; init; } 
    public string? Role { get; init; }
}