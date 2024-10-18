using ProEventos.Application.Contracts;
using ProEventos.Domain.Entities;
using ProEventos.Persistence.Contracts;

namespace ProEventos.Application.Services
{
    public class EventoService : IEventoService
    {
        private readonly IGeralPersistence geralPersist;
        private readonly IEventosPersistence eventoPersist;
        public EventoService(IGeralPersistence geralPersist, IEventosPersistence eventoPersist)
        {
            this.eventoPersist = eventoPersist;
            this.geralPersist = geralPersist;
            
        }
        public async Task<Evento> AddEventos(Evento model)
        {
            try
            {
                geralPersist.Add<Evento>(model);

                if (await geralPersist.SaveChangesAsync())
                {
                    return await eventoPersist.GetEventoById(model.Id, false);
                }
                return null;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Evento> UpdateEvento(int EventoId, Evento model)
        {
            try
            {
                var evento = await eventoPersist.GetEventoById(EventoId);
            
                if (evento == null) return null;


               geralPersist.Update(model);
               if (await geralPersist.SaveChangesAsync())
               {
                   return await eventoPersist.GetEventoById(EventoId, false);
               }
                return null;
            }
            catch (Exception ex)
            {
               throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteEvento(int EventoId)
        {
            try
            {
                var evento = await eventoPersist.GetEventoById(EventoId);
                if (evento == null) throw new Exception("Não foi encontrado o evento para Deletar");

               geralPersist.Delete<Evento>(evento);
               
               return await geralPersist.SaveChangesAsync();

            }
            catch (Exception ex)
            {
               
               throw new Exception(ex.Message);
            }
        }

        public Task<Evento[]> GetAllEventos(bool IncludePalestrantes = false)
        {
            throw new NotImplementedException();
        }

        public Task<Evento[]> GetAllEventosByTema(string Tema, bool IncludePalestrantes = false)
        {
            throw new NotImplementedException();
        }

        public Task<Evento> GetEventoById(int ID, bool IncludePalestrantes = false)
        {
            throw new NotImplementedException();
        }
    }
}