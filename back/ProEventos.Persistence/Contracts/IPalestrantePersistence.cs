using ProEventos.Domain.Entities;

namespace ProEventos.Persistence.Contracts
{
    public interface IPalestrantePersistence
    {
        Task<Palestrante[]> GetAllPalestrantes(bool IncludeEventos);
        Task<Palestrante[]> GetAllPalestratesByName(string Nome, bool IncludeEventos);
        Task<Palestrante> GetPalestranteById(int ID, bool IncludeEventos);
    }
}