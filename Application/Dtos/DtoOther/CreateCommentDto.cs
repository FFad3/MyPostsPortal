using Application.Dtos.Mapper;
using AutoMapper;
using Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Application.Dtos.DtoOther
{
    public class CreateCommentDto : IMap
    {
        [Required]
        public int PostId { get; set; }
        [Required]
        public int AccountId { get; set; }
        [Required,MaxLength(100)]
        public string Text { get; set; }
        [Required, MaxLength(30)]
        public string AccountUsername { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateCommentDto,Comment>();
            profile.CreateMap<Comment,CreateCommentDto>();
        }
    }
}
