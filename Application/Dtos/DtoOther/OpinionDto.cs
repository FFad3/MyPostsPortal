using Application.Dtos.Mapper;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.DtoOther
{
    public class OpinionDto : IMap
    {
        public bool IsLike { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<OpinionDto,Opinion>();
            profile.CreateMap<Opinion,OpinionDto>();
        }
    }
}
