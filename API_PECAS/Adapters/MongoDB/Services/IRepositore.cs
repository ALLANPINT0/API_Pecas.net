using API_PECAS.Adapters.MongoDB.DTO;

namespace API_PECAS.Adapters.MongoDB.Services
{
    public interface IRepositore
    {
        Task CreateAsync(Pecas pecas);
        Task<Pecas> GetById(string id);
    }
}
