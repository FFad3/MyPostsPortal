using Application.Dtos.Mapper;
using AutoMapper;
using Domain.Entities;

namespace Application.Dtos.DtoAccount.DtoAccDetials
{
    public class AccountDetailsDto : IMap
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AccountDetailsDto,AccountDetails>();
            profile.CreateMap<AccountDetails,AccountDetailsDto>();
        }
    }
}
