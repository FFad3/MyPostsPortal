using Application.Dtos.Mapper;
using AutoMapper;
using Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Application.Dtos.DtoAccount.DtoPost
{
    public class PostContentDto : IMap
    {
        [Required, MaxLength(30)]
        public string Title { get; set; }

        [Required, MaxLength(400)]
        public string Text { get; set; }

        public string? Image { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<PostContentDto, PostContent>();
            profile.CreateMap<PostContent, PostContentDto>();
        }
    }
}