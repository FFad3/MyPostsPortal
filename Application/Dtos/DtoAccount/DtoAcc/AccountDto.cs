using Application.Dtos.DtoAccount.DtoAccDetials;
using Application.Dtos.Mapper;
using AutoMapper;
using Domain.Entities;

namespace Application.Dtos.DtoAccount.DtoAcc
{
    public class AccountDto : IMap
    {
        public string Username { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public AccountDetailsDto Details { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Account, AccountDto>().
                ForMember(x => x.Details, c => c.MapFrom(m => m.Details));
            profile.CreateMap<AccountDto, Account>().
                ForMember(x => x.Details, c => c.MapFrom(m => m.Details));
        }
    }
}
