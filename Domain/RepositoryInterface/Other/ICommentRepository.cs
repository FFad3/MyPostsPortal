using Domain.Entities;

namespace Domain.RepositoryInterface
{
    public interface ICommentRepository:IBaseRepository<Comment>
    {
        bool AcocuntExist(int id);
        bool PostExist(int id);
        string GetUsername(int id);
    }
}
