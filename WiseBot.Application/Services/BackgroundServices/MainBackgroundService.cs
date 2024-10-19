using Microsoft.Extensions.Hosting;

namespace WiseBot.Application.Services.BackgroundServices
{
    public class MainBackgroundService : BackgroundService
    {
        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await Task.Delay(5000);
        }
    }
}
