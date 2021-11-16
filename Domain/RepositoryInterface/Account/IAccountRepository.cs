using Domain.Entities;

namespace Domain.RepositoryInterface
{
    public interface IAccountRepository : IBaseRepository<Account>
    {
        Account Login(string Login, string Passowrd);
        bool LoginIsAvaiable(string Login);
    }
}
