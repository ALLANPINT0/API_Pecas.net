using API_PECAS.Adapters.MongoDB.DTO;
using API_PECAS.Adapters.MongoDB.Services;
using API_PECAS.ViewModel;

namespace API_PECAS.Application
{
    public class UseCases : IUseCase
    {
        private readonly IRepositore _repositore;
         public UseCases(IRepositore repositore)
        {
            _repositore = repositore;
        }
        public async Task<Pecas> CreatePecas(PecasRequest request)
        {
            var req = new Pecas
            {
                Name = request.Name,
                Price = request.Price,
                Ref = request.Ref,  
                Marca = request.Marca
            };
            await _repositore.CreateAsync(req);
            return req;
        }

        public async Task<Pecas> ReadPecas(string id)
        {
            var obj = await _repositore.GetById(id);
            return obj;
        }
    }
}
