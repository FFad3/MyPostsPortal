using Application.Dtos.Mapper;
using AutoMapper;
using Domain.Entities;

namespace Application.Dtos.DtoAccount.AccountDetailsDto
{
    public class CreateAccountDetailsDto : IMap
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateAccountDetailsDto,AccountDetails>();
        }
    }
}
