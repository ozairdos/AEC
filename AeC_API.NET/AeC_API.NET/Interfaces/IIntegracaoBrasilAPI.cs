using AeC_API.NET.Entities;

namespace AeC_API.NET.Interfaces
{
    public interface IIntegracaoBrasilAPI
    {
        Task<List<Cidade>> ConsultarCidades();

        Task<Previsao> ConsultarClimaPorCodigoCidade(string cityCode);

        Task<List<Aeroporto>> ConsultarAeroportos();

        Task<Aeroporto> ConsultarClimaPorCodigoAeroporto(string icaoCode);
    }
}
