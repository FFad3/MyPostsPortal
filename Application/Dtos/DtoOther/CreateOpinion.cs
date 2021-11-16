using Application.Dtos.Mapper;
using AutoMapper;
using Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Application.Dtos.DtoOther
{
    public class CreateOpinion : IMap
    {
        [Required]
        public int AccountId { get; set; }
        [Required]
        public int PostId { get; set; }
        [Required]
        public bool IsLike { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateOpinion, Opinion>();
        }
    }
}
