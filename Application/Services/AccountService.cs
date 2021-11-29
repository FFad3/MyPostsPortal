using Application.Dtos.DtoAcc;
using Application.ServiceInterfaces;
using Application.Services.Utilities;
using AutoMapper;
using Domain.Entities;
using Domain.RepositoryInterface;
using System.Security.Principal;

namespace Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IMapper _mapper;
        private readonly IAccountRepository _repository;

        public AccountService(IMapper mapper, IAccountRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public AccountDto Login(string username, string password)
        {
            //Hashing credentials
            username = DataHashing.StringToHash(username);
            password=DataHashing.StringToHash(password);

            var account = _repository.Login(username, password);

            var result = _mapper.Map<AccountDto>(account);
            return result;
        }

        public AccountDto Register(CreateAccountDto newAccount)
        {
            newAccount.Login = DataHashing.StringToHash((string)newAccount.Login);
            newAccount.Password = DataHashing.StringToHash((string)newAccount.Password);

            //Check if login is available
            if (_repository.LoginIsAvaiable(newAccount.Login)) return null;

            var account = _mapper.Map<Account>(newAccount);
                account.Created = DateTime.Now;

            var result = _repository.Add(account);

            return _mapper.Map<AccountDto>(result);
        }

        public IEnumerable<AccountDto> GetAccounts()
        {
            var accounts = _repository.GetAll();
            var result = _mapper.Map<IEnumerable<AccountDto>>(accounts);
            return result;
        }

        public bool Remove(int id)
        {
            var account = _repository.GetById(id);

            if (account is null) return false;

            _repository.RemoveComments(id);
            _repository.RemoveOpinions(id);
            _repository.Delete(account);

            return true;
        }

        public bool Update(UpdateAccountDto updateAccount)
        {
            updateAccount.Login = DataHashing.StringToHash(updateAccount.Login);
            updateAccount.Password = DataHashing.StringToHash(updateAccount.Password);

            if (_repository.LoginIsAvaiable(updateAccount.Login)) return false;

            var existingAccount = _repository.GetById(updateAccount.AccountId);
            if (existingAccount is null) return false;

            var currentAccount = _mapper.Map(updateAccount, existingAccount);

            _repository.Update(currentAccount);

            return true;
        }

    }
}
