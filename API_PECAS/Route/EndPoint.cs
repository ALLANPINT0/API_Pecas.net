using API_PECAS.Application;
using API_PECAS.ViewModel;

namespace API_PECAS.Route
{
    public static class EndPoint
    {
        public static void AddEndpoints(this WebApplication app)
        {
            app.MapPost("/CadastrarPecas", CadastrarAsync);
            app.MapGet("/BuscarPecasPorId", BuscarPorIdAsync);
            app.MapPut("/AlterarPecas", AlterarPecas);
            app.MapDelete("/DeletarPecas", DeletarPecas);


        }
        private static async Task<IResult> CadastrarAsync(IUseCase usecase, PecasRequest vm)
        {
            try
            {
                var obj = await usecase.CreatePecas(vm);

                return Results.Created("/CadastrarPecas", obj);
            }
            catch (Exception ex)
            {
                return Results.Json(new
                {
                    codigo = "500",
                    mensagem = "Problema ao criar uma Peca",
                    descricao = ex.Message
                }, statusCode: 500);
            }

        }

        private static async Task<IResult> BuscarPorIdAsync(IUseCase useCase, string id)
        {
            try
            {
                var obj = await useCase.ReadPecas(id);
                return Results.Ok(obj);
            }
            catch (Exception ex)
            {
                return Results.Json(new
                {
                    codigo = "500",
                    mensagem = "Problema ao buscar uma peca por id",
                    descricao = ex.Message
                }, statusCode: 500);

            }
        }
        private static async Task<IResult> AlterarPecas(IUseCase useCase,PecasRequest request, string id)
        {
            try
            {
                await useCase.UpdatePecas(id, request);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Json(new
                {
                    codigo = "500",
                    mensagem = "Problema ao buscar uma peca por id",
                    descricao = ex.Message
                }, statusCode: 500);
                
            }
        }
        private static async Task<IResult> DeletarPecas(IUseCase useCase, string id)
        {
            try
            {
                await useCase.RemovePecas(id);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Json(new
                {
                    codigo = "500",
                    mensagem = "Problema ao buscar uma peca por id",
                    descricao = ex.Message
                }, statusCode: 500);
                
            }
        }
    }
}
