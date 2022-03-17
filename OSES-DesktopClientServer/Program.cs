using Microsoft.AspNetCore.HttpOverrides;
using OSES_DesktopClientServer.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureCors();
builder.Services.ConfigureIISIntegration();

builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
    // Exception Handling middleware
    app.UseDeveloperExceptionPage();
else
    // forces https
    app.UseHsts();

// redirects http calls to https
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.All
});

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();