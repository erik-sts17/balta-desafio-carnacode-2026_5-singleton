using Singleton.Domain.Abstractions;
using Singleton.Infra.Configurations;

namespace Singleton.Infra.Services
{
    public class DatabaseService : IDatabaseService
    {
        private readonly ConfigurationManager _config = ConfigurationManager.Instance;

        public void Connect()
        {
            var connectionString = _config.GetSetting("DatabaseConnection");
            Console.WriteLine($"[DatabaseService] Conectando ao banco: {connectionString}");
        }

    }
}