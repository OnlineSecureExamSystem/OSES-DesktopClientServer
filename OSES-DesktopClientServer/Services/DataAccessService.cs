using System.Data;
using System.Data.SqlClient;
using OSES_DesktopClientServer.Contracts;

namespace OSES_DesktopClientServer.Services;

public class DataAccessService : IDataAccessService
{
    private readonly ILoggerManager _logger;
    private readonly IConfiguration _configuration;
    //private readonly IHttpClientFactory _httpClientFactory;

    public DataAccessService(ILoggerManager logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public IDbConnection GetConnection()
    {
        var connectionString = _configuration.GetConnectionString("DefaultConnection");
        IDbConnection connection = new SqlConnection(connectionString);
        if (connection.State == ConnectionState.Closed)
        {
            connection.Open();
            _logger.LogInfo("Database connection opened.");
        }
        return connection;
    }
   
}