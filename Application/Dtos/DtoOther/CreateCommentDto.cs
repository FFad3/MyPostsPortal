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
    public class CreateCommentDto : IMap
    {
        [Required]
        public int PostId { get; set; }
        [Required]
        public int AccountId { get; set; }
        [Required,MaxLength(100)]
        public string Text { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateCommentDto,Comment>();
            profile.CreateMap<Comment,CreateCommentDto>();
        }
    }
}
