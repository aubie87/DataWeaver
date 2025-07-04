using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DataWeaver.Generator.App;

public class GeneratorApp : BackgroundService
{
    private readonly ILogger<GeneratorApp> _logger;

    public GeneratorApp(ILogger<GeneratorApp> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("GeneratorApp started.");

        await Task.Delay(10, stoppingToken);

        try
        {
            // Main application logic goes here
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("GeneratorApp is running at: {time}", DateTimeOffset.Now);

                // Add your application logic here
                var statement = SampleStatementBuilder.CreateSampleStatement();
                _logger.LogInformation($"Statement ID: {statement.StatementId} with {statement.Accounts.Count} accounts.");
                foreach (var account in statement.Accounts)
                {
                    _logger.LogInformation($"  Account Number: {account.AccountNumber}");
                }

                await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
            }
        }
        catch (OperationCanceledException)
        {
            // This is expected when the application is shutting down
            _logger.LogInformation("GeneratorApp is stopping due to cancellation.");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred in GeneratorApp.");
        }
        finally
        {
            _logger.LogInformation("GeneratorApp stopped.");
        }
    }
}