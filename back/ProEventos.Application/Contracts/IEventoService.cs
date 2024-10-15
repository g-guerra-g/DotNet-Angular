using ProEventos.Domain.Entities;

namespace ProEventos.Application.Contracts
{
    public interface IEventoService
    {
        Task<Evento> AddEventos(Evento model);
        Task<Evento> UpdateEvento(int EventoId, Evento model);
        Task<bool> DeleteEvento(int EventoId);

        Task<Evento[]> GetAllEventos(bool IncludePalestrantes = false);
        Task<Evento[]> GetAllEventosByTema(string Tema, bool IncludePalestrantes = false);
        Task<Evento> GetEventoById(int ID, bool IncludePalestrantes = false);
    }
}