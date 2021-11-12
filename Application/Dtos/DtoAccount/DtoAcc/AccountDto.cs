using Application.Dtos.DtoAccount.DtoAccDetials;
using Application.Dtos.Mapper;
using AutoMapper;
using Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Application.Dtos.DtoAccount.DtoAcc
{
    public class AccountDto : IMap
    {
        public int AccountId { get; set; }
        [Required,MaxLength(30),MinLength(8)]
        public string Username { get; set; } = String.Empty;
        [Required,MaxLength(30),MinLength(8)]
        public string Login { get; set; } = String.Empty;
        [Required,MaxLength (30), MinLength(8)]
        public string Password { get; set; } = String.Empty;
        [Required]
        public AccountDetailsDto Details { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Account, AccountDto>().
                ForMember(x => x.Details, c => c.
                MapFrom(m => m.Details));

            profile.CreateMap<AccountDto, Account>().
                ForMember(x => x.Details, c => c.
                MapFrom(m => m.Details));
        }
    }
}
