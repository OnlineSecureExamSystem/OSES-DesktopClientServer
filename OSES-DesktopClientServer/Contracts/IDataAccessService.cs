using System.Data;

namespace OSES_DesktopClientServer.Contracts;

public interface IDataAccessService
{
    public IDbConnection GetConnection();
  
}