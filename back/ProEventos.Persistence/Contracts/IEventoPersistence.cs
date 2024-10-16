using ProEventos.Domain.Entities;

namespace ProEventos.Persistence.Contracts
{
    public interface IEventosPersistence
    {
        Task<Evento[]> GetAllEventos(bool IncludePalestrantes = false);
        Task<Evento[]> GetAllEventosByTema(string Tema, bool IncludePalestrantes = false);
        Task<Evento> GetEventoById(int ID, bool IncludePalestrantes = false);
    }
}