using ProEventos.Domain.Entities;

namespace ProEventos.Persistence.Contracts
{
    public interface IPalestrantePersistence
    {
        Task<Palestrante[]> GetAllPalestrantes(bool IncludeEventos = false);
        Task<Palestrante[]> GetAllPalestratesByName(string Nome, bool IncludeEventos = false);
        Task<Palestrante> GetPalestranteById(int ID, bool IncludeEventos = false);
    }
}