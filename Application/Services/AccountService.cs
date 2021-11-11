using Application.Dtos.DtoAccount.DtoAcc;
using Application.ServiceInterfaces;
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
            var credentials = _repository.Login(username, password);
            var result = _mapper.Map<AccountDto>(credentials);

            return result;
        }

        public AccountDto Register(AccountDto newAccount)
        {
            var account = _mapper.Map<Account>(newAccount);
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
