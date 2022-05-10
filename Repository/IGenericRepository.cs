using apiTemplate.Models;

namespace apiTemplate.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        T Insert(T obj);
        T Update(T obj);
        T Delete(T obj);
        T Save(T obj);
    }
}
