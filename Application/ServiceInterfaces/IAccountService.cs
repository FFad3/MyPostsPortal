using Application.Dtos.DtoAccount.DtoAcc;

namespace Application.ServiceInterfaces
{
    public interface IAccountService
    {
        AccountDto Register(AccountDto newAccount);
        AccountDto Login(string username, string password);
        IEnumerable<AccountDto> GetAccounts();

    }
}
