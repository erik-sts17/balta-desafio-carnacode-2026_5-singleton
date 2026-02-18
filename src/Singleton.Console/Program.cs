using Microsoft.Extensions.DependencyInjection;
using Singleton.Console.Configurations;
using Singleton.Domain.Abstractions;
using Singleton.Infra.Configurations;

Console.WriteLine("=== Sistema de Configurações ===\n");

var services = new ServiceCollection();

services.AddServices();

var provider = services.BuildServiceProvider();

var dbService = provider.GetRequiredService<IDatabaseService>();
var apiService = provider.GetRequiredService<IApiService>();
var cacheService = provider.GetRequiredService<ICacheService>();
var logService = provider.GetRequiredService<ILoggingService>();

dbService.Connect();
apiService.MakeRequest();
cacheService.Connect();
logService.Log("Sistema iniciado");

Console.WriteLine("\n--- Atualizando configuração ---\n");

ConfigurationManager.Instance.UpdateSetting("LogLevel", "Debug");

Console.WriteLine($"Novo LogLevel: {ConfigurationManager.Instance.GetSetting("LogLevel")}");