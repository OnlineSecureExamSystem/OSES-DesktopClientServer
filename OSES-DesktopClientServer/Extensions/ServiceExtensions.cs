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
}