using Application.Dtos.DtoAccount.DtoAcc;
using Application.ServiceInterfaces;
using Application.Services.Utilities;
using AutoMapper;
using Domain.Entities;
using Domain.RepositoryInterface;

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

        public AccountDto Register(AccountDto newAccount)
        {
            var account = _mapper.Map<Account>(newAccount);
            //TODO:Password and login rules
            //Check if login is avaiable
            if(_repository.LoginIsAvaiable(account.Login) is null)
            {
                account.Created = DateTime.Now;
                //Hashing credentials
                account.Login = DataHashing.StringToHash(account.Login);
                account.Password = DataHashing.StringToHash(account.Password);

                var result = _repository.Add(account);
                return _mapper.Map<AccountDto>(result);
            }
            //TODO: If login is used communicate
            return null;
            
        }

        public IEnumerable<AccountDto> GetAccounts()
        {
            var accounts = _repository.GetAll();
            var result = _mapper.Map<IEnumerable<AccountDto>>(accounts);
            return result;
        }

    }
}
