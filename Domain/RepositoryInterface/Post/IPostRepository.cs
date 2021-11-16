using Domain.Entities;

namespace Domain.RepositoryInterface
{
    public interface IPostRepository : IBaseRepository<Post>
    {
        bool AccountExist(int id);
        string GetUsername(int id);
    }
}
