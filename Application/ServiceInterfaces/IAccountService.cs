using Application.Dtos.DtoAccount.AccountDto;

namespace Application.ServiceInterfaces
{
    public interface IAccountService
    {
        CreateAccountDto CreatAccount(CreateAccountDto newAccount);
        IEnumerable<CreateAccountDto> GetAccounts();
    }
}
