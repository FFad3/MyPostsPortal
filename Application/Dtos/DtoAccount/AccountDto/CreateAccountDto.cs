using Application.Dtos.DtoAccount.AccountDetailsDto;
using Application.Dtos.Mapper;
using AutoMapper;
using Domain.Entities;

namespace Application.Dtos.DtoAccount.AccountDto
{
    public class CreateAccountDto : IMap
    {
        public string Username { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public CreateAccountDetailsDto Details { get; set; }

        public void Mapping(Profile profile)
        {
            //Account mapping
            profile.CreateMap<CreateAccountDto, Account>().
                ForMember(x => x.Details, c => c.MapFrom(m => m.Details));
            profile.CreateMap<Account, CreateAccountDto>().
                ForMember(x => x.Details, c => c.MapFrom(m => m.Details));

        }
    }
}
