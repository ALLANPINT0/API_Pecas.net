using API_PECAS.Adapters.MongoDB.DTO;

namespace API_PECAS.Adapters.MongoDB.Services
{
    public interface IRepositore
    {
        Task CreateAsync(Pecas pecas);
        Task<Pecas> GetById(string id);
        Task RemoveAsync(string id);
        Task UpdateAsync(string id, Pecas pecas);


    }
}
