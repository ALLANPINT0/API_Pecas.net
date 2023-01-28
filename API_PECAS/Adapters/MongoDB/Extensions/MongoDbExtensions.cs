using API_PECAS.Adapters.MongoDB.Services;
using API_PECAS.Adapters.MongoDB.Settings;

namespace API_PECAS.Adapters.MongoDB.Extensions
{
    public static class MongoDbExtensions
    {
        public static IServiceCollection AddMongoDB(this IServiceCollection service)
        {
            IConfiguration configuration = new ConfigurationBuilder()
              .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json")
              .Build();

            var resulta = service.Configure<MongoSettings>(
             configuration.GetSection("MongoDBConn"));
             service.AddScoped<IRepositore, Repositore>();


            return service;
        }
    }
}
