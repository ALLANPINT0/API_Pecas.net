using API_PECAS.Adapters.MongoDB.DTO;
using API_PECAS.ViewModel;

namespace API_PECAS.Application
{
    public interface IUseCase 
    {
        Task<Pecas> CreatePecas(PecasRequest  request);
        Task<Pecas> ReadPecas(string id);
        Task RemovePecas(string id);
        Task UpdatePecas(string id,PecasRequest request);

    }
}
