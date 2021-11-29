using Application.Dtos.Mapper;
using AutoMapper;
using Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Application.Dtos.DtoOther
{
    public class UpdateCommentDto : IMap
    {
        [Required]
        public int CommentId { get; set; }

        [Required, MaxLength(100)]
        public string Text { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateCommentDto, Comment>();
        }
    }
}
