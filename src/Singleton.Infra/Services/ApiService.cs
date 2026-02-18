using Singleton.Domain.Abstractions;
using Singleton.Infra.Configurations;

namespace Singleton.Infra.Services
{
    public class ApiService : IApiService
    {
        private readonly ConfigurationManager _config = ConfigurationManager.Instance;

        public void MakeRequest()
        {
            var apiKey = _config.GetSetting("ApiKey");
            Console.WriteLine($"[ApiService] Fazendo requisição com API Key: {apiKey}");
        }
    }
}