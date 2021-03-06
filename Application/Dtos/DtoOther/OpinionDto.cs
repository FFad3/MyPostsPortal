using Application.Dtos.Mapper;
using AutoMapper;
using Domain.Entities;

namespace Application.Dtos.DtoOther
{
    public class OpinionDto : IMap
    {
        public int AccountId { get; set; }
        public int PostId { get; set; }
        public bool IsLike { get; set; }
        public DateTime Created { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<OpinionDto,Opinion>();
            profile.CreateMap<Opinion,OpinionDto>();
        }
    }
}
