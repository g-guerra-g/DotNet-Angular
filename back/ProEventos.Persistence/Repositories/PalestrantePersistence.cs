using Microsoft.EntityFrameworkCore;
using ProEventos.Domain.Entities;
using ProEventos.Persistence.Context;
using ProEventos.Persistence.Contracts;

namespace ProEventos.Persistence.Repositories
{
    public class PalestrantePersistence : IPalestrantePersistence
    {
        public ProEventosContexto contexto { get; }
        public PalestrantePersistence(ProEventosContexto contexto)
        {
            this.contexto = contexto;
        }
        public async Task<Palestrante[]> GetAllPalestrantes(bool IncludeEventos = false)
        {
            IQueryable<Palestrante> query = contexto.Palestrantes.Include(P => P.RedesSociais);

            if (IncludeEventos)
            {
                query = query.Include(P => P.EventosPalestrantes).ThenInclude(EP => EP.PalestranteId);
            }

            return await query.ToArrayAsync();
        }

        public async Task<Palestrante[]> GetAllPalestratesByName(string Nome, bool IncludeEventos = false)
        {
            IQueryable<Palestrante> query = contexto.Palestrantes.Include(P => P.RedesSociais);

            if (IncludeEventos)
            {
                query = query.Include(P => P.EventosPalestrantes).ThenInclude(EP => EP.PalestranteId);
            }

            query = query.Where(P => P.Nome == Nome);

            return await query.ToArrayAsync();
        }

        public async Task<Palestrante> GetPalestranteById(int ID, bool IncludeEventos = false)
        {
            IQueryable<Palestrante> query = contexto.Palestrantes.Include(P => P.RedesSociais);

            if (IncludeEventos)
            {
                query = query.Include(P => P.EventosPalestrantes).ThenInclude(EP => EP.PalestranteId);
            }

            query = query.Where(P => P.Id == ID);

            return await query.FirstOrDefaultAsync();
        }
    }
}