using API_PECAS.Adapters.MongoDB.DTO;
using API_PECAS.Adapters.MongoDB.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace API_PECAS.Adapters.MongoDB.Services
{
    public class Repositore : IRepositore
    {
        private IMongoCollection<Pecas> _mongocollection;
        private readonly IMongoDatabase _mongoData;
        public Repositore(IOptions<MongoSettings> options)
        {
            _mongoData = new MongoClient(options.Value.Url).GetDatabase(options.Value.Database);
            _mongocollection = _mongoData.GetCollection<Pecas>("Pecas");
        }
        public async Task CreateAsync(Pecas pecas) =>
            await _mongocollection.InsertOneAsync(pecas);


        public async Task<Pecas> GetById(string id) =>
            await _mongocollection.Find(x => x._id == id).FirstOrDefaultAsync();
    }
}
