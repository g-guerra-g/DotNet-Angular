using ProEventos.Domain.Entities;

namespace ProEventos.Application.Contracts
{
    public interface IPalestranteService
    {
        Task<Palestrante> AddPalestrantes(Palestrante model);
        Task<Palestrante> UpdatePalestrante(int IdPalesntrante, Palestrante model);
        Task<Palestrante> DeletePalestrante(int IdPalestrante);
        Task<Palestrante[]> GetAllPalestrantes(bool IncludeEventos = false);
        Task<Palestrante[]> GetAllPalestratesByName(string Nome, bool IncludeEventos = false);
        Task<Palestrante> GetPalestranteById(int ID, bool IncludeEventos = false);
        
        
    }
}