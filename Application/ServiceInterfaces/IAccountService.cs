using Application.Dtos.DtoAcc;

namespace Application.ServiceInterfaces
{
    public interface IAccountService
    {
        AccountDto Register(CreateAccountDto newAccount);
        AccountDto Login(string username, string password);
        void Remove(int id);
        IEnumerable<AccountDto> GetAccounts();

    }
}
