using DataWeaver.Generator.App;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

var builder = Host.CreateApplicationBuilder(args);

// Configure Serilog from configuration
builder.Services.AddSerilog((services, loggerConfiguration) =>
{
    loggerConfiguration.ReadFrom.Configuration(builder.Configuration);
});

// Register the GeneratorApp as a hosted service
builder.Services.AddHostedService<GeneratorApp>();

var host = builder.Build();

await host.RunAsync();
