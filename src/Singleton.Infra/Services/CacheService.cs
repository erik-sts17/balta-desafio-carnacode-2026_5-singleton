using Singleton.Domain.Abstractions;
using Singleton.Infra.Configurations;

namespace Singleton.Infra.Services
{
    public class CacheService : ICacheService
    {
        private readonly ConfigurationManager _config = ConfigurationManager.Instance;

        public void Connect()
        {
            var cacheServer = _config.GetSetting("CacheServer");
            Console.WriteLine($"[CacheService] Conectando ao cache: {cacheServer}");
        }
    }
}