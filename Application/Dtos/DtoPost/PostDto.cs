using Application.Dtos.DtoOther;
using Application.Dtos.Mapper;
using AutoMapper;
using Domain.Entities;

namespace Application.Dtos.DtoAccount.DtoPost
{
    public class PostDto :IMap
    {
        public int PostId { get; set; }
        public int AccountId { get; set; }
        public DateTime Created { get; set; }
        public int Likes { get; set; } = 0;
        public int Dislikes { get; set; } = 0;
        public PostContentDto Content { get; set; }
        public List<CommentDto> Comments { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Post, PostDto>().
                ForMember(x => x.Likes, c => c.MapFrom(m => m.Opinions.Where(x => x.IsLike == true).Count())). //Likes count

                ForMember(x => x.Dislikes, c => c.MapFrom(m => m.Opinions.Where(x => x.IsLike == false).Count())). //Dislikes count

                ForMember(x => x.Comments, c => c.MapFrom(m => m.Comments)).

                ForMember(x => x.Content, c => c.MapFrom(m => m.Content));
        }
    }
}
