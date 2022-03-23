namespace OSES_DesktopClientServer.Models.Exceptions;

// base class for all not found exceptions
public abstract class NotFoundException : Exception
{
    protected NotFoundException(string message) : base(message)
    {
        
    }
}