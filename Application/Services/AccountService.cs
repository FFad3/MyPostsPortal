using Application.Dtos.DtoAccount.DtoAcc;
using Application.ServiceInterfaces;
using Application.Services.Utilities;
using AutoMapper;
using Domain.Entities;
using Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //Hashing
            username=DataHashing.StringToHash(username);
            password=DataHashing.StringToHash(password);

            var account = _repository.Login(username, password);

            var result = _mapper.Map<AccountDto>(account);
            return result;
        }

        public AccountDto Register(AccountDto newAccount)
        {
            var account = _mapper.Map<Account>(newAccount);
            //TODO:Password and login rules
            //Hashing credentials
            account.Login = DataHashing.StringToHash(account.Login);
            account.Password = DataHashing.StringToHash(account.Password);

            var result =_repository.Add(account);
            return _mapper.Map<AccountDto>(result);
        }


        public IEnumerable<AccountDto> GetAccounts()
        {
            var accounts = _repository.GetAll();
            var result = _mapper.Map<IEnumerable<AccountDto>>(accounts);
            return result;
        }

    }
}
