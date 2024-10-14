using ProEventos.Domain.Entities;

namespace ProEventos.Persistence.Contracts
{
    public interface IEventosPersistence
    {
        Task<Evento[]> GetAllEventos(bool IncludePalestrantes);
        Task<Evento[]> GetAllEventosByTema(string Tema, bool IncludePalestrantes);
        Task<Evento> GetEventoById(int ID, bool IncludePalestrantes);
    }
}