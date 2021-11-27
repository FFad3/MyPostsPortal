using Application.Dtos.Mapper;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.DtoAcc
{
    public class UpdateAccountDto : IMap
    {
        public int AccountId { get; set; }
        [Required, MaxLength(30), MinLength(8)]
        public string Username { get; set; } = String.Empty;
        [Required, MaxLength(32), MinLength(8)]
        public string Login { get; set; } = String.Empty;
        [Required, MaxLength(32), MinLength(8)]
        public string Password { get; set; } = String.Empty;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateAccountDto,Account>();
        }
    }
}
