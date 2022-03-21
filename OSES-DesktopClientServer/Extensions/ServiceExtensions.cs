using System.Data;
using OSES_DesktopClientServer.Contracts;
using OSES_DesktopClientServer.Services;

namespace OSES_DesktopClientServer.Extensions;

public static class ServiceExtensions
{
    // CORS configuration
    public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin() // allowed domains
                    .AllowAnyMethod() // allowed http methods
                    .AllowAnyHeader()); // allowed http headers
        });

    // IIS configuration (needed since the app will be hosted on IIS)
    public static void ConfigureIISIntegration(this IServiceCollection services) =>
        services.Configure<IISOptions>(options =>
        {
            // default configuration for now
        });
    
    // Logger configuration
    public static void ConfigureLoggerService(this IServiceCollection services) =>
        services.AddSingleton<ILoggerManager, LoggerManager>();
    
    // DataAccess  configuration
    public static void ConfigureDataAccess(this IServiceCollection services) =>
        services.AddScoped<IDataAccessService, DataAccessService>();
    
    // UserService configuration
    public static void ConfigureUserService(this IServiceCollection services) =>
        services.AddScoped<IUserService, UserService>();
    
    // service manager configuration
    // public static void ConfigureServiceManager(this IServiceCollection services) =>
    //     services.AddTransient<IServiceManager, ServiceManager>();
    
   
    
        
}