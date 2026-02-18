namespace Singleton.Infra.Configurations
{
    public sealed class ConfigurationManager
    {
        private readonly Dictionary<string, string> _settings;
        private bool _isLoaded;
        private static readonly Lazy<ConfigurationManager> _instance =
            new(() => new ConfigurationManager(), LazyThreadSafetyMode.ExecutionAndPublication);

        public static ConfigurationManager Instance => _instance.Value;

        private ConfigurationManager()
        {
            _settings = [];
            _isLoaded = false;
            Console.WriteLine("Singleton ConfigurationManager criado!");
        }

        public void LoadConfigurations()
        {
            if (_isLoaded)
                return;

            Console.WriteLine("Carregando configurações...");

            Thread.Sleep(200);

            _settings["DatabaseConnection"] = "Server=localhost;Database=MyApp;";
            _settings["ApiKey"] = "abc123xyz789";
            _settings["CacheServer"] = "redis://localhost:6379";
            _settings["MaxRetries"] = "3";
            _settings["TimeoutSeconds"] = "30";
            _settings["EnableLogging"] = "true";
            _settings["LogLevel"] = "Information";

            _isLoaded = true;
            Console.WriteLine("Configurações carregadas com sucesso!\n");
        }

        public string? GetSetting(string key)
        {
            if (!_isLoaded)
                LoadConfigurations();

            return _settings.TryGetValue(key, out var value)
                ? value
                : null;
        }

        public void UpdateSetting(string key, string value)
        {
            _settings[key] = value;
            Console.WriteLine($"Configuração atualizada: {key} = {value}");
        }
    }
}