using ProEventos.Persistence.Context;
using ProEventos.Persistence.Contracts;

namespace ProEventos.Persistence.Repositories
{
    public class GeralPersistence : IGeralPersistence
    {
        public ProEventosContexto contexto;
        public GeralPersistence(ProEventosContexto contexto)
        {
            this.contexto = contexto;
        }

        public void Add<T>(T Entities) where T : class
        {
            contexto.Add(Entities);
        }

        public void Update<T>(T Entities) where T : class
        {
            contexto.Update(Entities);
        }

        public void Delete<T>(T Entities) where T : class
        {
            contexto.Remove(Entities);
        }

        public void RangeDelete<T>(T[] EntitiesArray) where T : class
        {
            contexto.RemoveRange(EntitiesArray);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await contexto.SaveChangesAsync()) > 0;
        }
    }
}