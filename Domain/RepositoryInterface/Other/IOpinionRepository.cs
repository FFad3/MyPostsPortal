using Domain.Entities;

namespace Domain.RepositoryInterface
{
    public interface IOpinionRepository : IBaseRepository<Opinion>
    {
        bool AcocuntExist(int id);
        bool PostExist(int id);
    }
}
