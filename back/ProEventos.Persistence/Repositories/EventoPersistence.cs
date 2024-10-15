using Microsoft.EntityFrameworkCore;
using ProEventos.Domain.Entities;
using ProEventos.Persistence.Context;
using ProEventos.Persistence.Contracts;

namespace ProEventos.Persistence.Repositories
{
    public class EventoPersistence : IEventosPersistence
    {
        private readonly ProEventosContexto contexto;
        public EventoPersistence(ProEventosContexto contexto)
        {
            this.contexto = contexto;
        }

        public async Task<Evento[]> GetAllEventos(bool IncludePalestrantes = false)
        {
            IQueryable<Evento> query = contexto.Eventos.Include(E => E.Lotes).Include(E => E.RedesSociais);

            if (IncludePalestrantes)
            {
                query = query.Include(E => E.EventosPalestrantes).ThenInclude(EP => EP.Evento);
            }

            return await query.ToArrayAsync();
        }

        public async Task<Evento[]> GetAllEventosByTema(string Tema, bool IncludePalestrantes = false)
        {
            IQueryable<Evento> query = contexto.Eventos.Include(E => E.Lotes).Include(E => E.RedesSociais);

            if (IncludePalestrantes)
            {
                query = query.Include(E => E.EventosPalestrantes).ThenInclude(EP => EP.Evento);
            }

            query = query.Where(E => E.TemaEvento == Tema);

            return await query.ToArrayAsync();
        }

        public async Task<Evento> GetEventoById(int ID, bool IncludePalestrantes = false)
        {
            IQueryable<Evento> query = contexto.Eventos.Include(E => E.Lotes).Include(E => E.RedesSociais);

            if (IncludePalestrantes)
            {
                query = query.Include(E => E.EventosPalestrantes).ThenInclude(EP => EP.Evento);
            }

            query = query.Where(E => E.Id == ID);

            return await query.FirstOrDefaultAsync();
        }
    }
}