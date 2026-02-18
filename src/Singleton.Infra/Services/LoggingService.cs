using Singleton.Domain.Abstractions;
using Singleton.Infra.Configurations;

namespace Singleton.Infra.Services
{
    public class LoggingService : ILoggingService
    {
        private readonly ConfigurationManager _config = ConfigurationManager.Instance;

        public void Log(string message)
        {
            var logLevel = _config.GetSetting("LogLevel");
            Console.WriteLine($"[LoggingService] [{logLevel}] {message}");
        }
    }
}