using Application.Dtos.DtoAccount.AccountDto;
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

        public CreateAccountDto CreatAccount(CreateAccountDto newAccount)
        {
            var account = _mapper.Map<Account>(newAccount);
            var result = _repository.Add(account);

            return _mapper.Map<CreateAccountDto>(result);
        }

        public IEnumerable<CreateAccountDto> GetAccounts()
        {
            var accounts = _repository.GetAll();
            var result = _mapper.Map<IEnumerable<CreateAccountDto>>(accounts);
            return result;
        }
    }
}
