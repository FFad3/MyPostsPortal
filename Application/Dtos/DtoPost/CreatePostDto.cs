using Application.Dtos.DtoAccount.DtoPost;
using Application.Dtos.Mapper;
using AutoMapper;
using Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace Application.Dtos.DtoPost
{
    public class CreatePostDto :IMap
    {
        [Required]
        public int AccountId { get; set; }
        [Required]
        public PostContentDto Content { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreatePostDto, Post>().ForMember(x => x.Content, c => c.MapFrom(m => m.Content));
        }
    }
}
