namespace ProEventos.Persistence.Contracts
{
    public interface IGeralPersistence
    {
        void Add<T>(T Entities)where T: class;
        void Update<T>(T Entities)where T: class;
        void Delete<T>(T Entities)where T: class;
        void RangeDelete<T>(T[] Entities)where T: class;
        Task<bool> SaveChangesAsync();
    }
}