using Application.Dtos.Mapper;
using AutoMapper;
using Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Application.Dtos.DtoAccDetials
{
    public class AccountDetailsDto : IMap
    {
        [Required, MaxLength(30),MinLength(3)]
        public string Name { get; set; } = String.Empty;

        [Required, MaxLength(30), MinLength(3)]
        public string Surname { get; set; } = String.Empty;

        [Required, EmailAddress, MaxLength(30), MinLength(6)]
        public string Email { get; set; } = String.Empty;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AccountDetailsDto,AccountDetails>();
            profile.CreateMap<AccountDetails,AccountDetailsDto>();
        }
    }
}
