using Domain.Entities;

namespace Domain.RepositoryInterface
{
    public interface IBaseRepository<T> where T : EntityBase
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Add(T ob);
        void Update(T ob);
        void Delete(T ob);
    }
}
