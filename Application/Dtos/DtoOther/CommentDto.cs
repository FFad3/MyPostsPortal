using Application.Dtos.Mapper;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.DtoOther
{
    public class CommentDto : IMap
    {
        public string Text { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CommentDto, Comment>();
            profile.CreateMap<Comment, CommentDto>();
        }
    }
}
