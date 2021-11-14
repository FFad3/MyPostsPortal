using Application.Dtos.DtoOther;
using Application.ServiceInterfaces;
using AutoMapper;
using Domain.Entities;
using Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _repository;
        private readonly IAccountRepository _accountRepository;
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;

        public CommentService(ICommentRepository repository, IAccountRepository accountRepository, IPostRepository postRepository, IMapper mapper)
        {
            _repository = repository;
            _accountRepository = accountRepository;
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public CommentDto CreateComment(CreateCommentDto newComment)
        {
            var comment = _mapper.Map<Comment>(newComment);

            comment.Created = DateTime.Now;

            var result = _repository.Add(comment);

            return _mapper.Map<CommentDto>(result);
        }
    }
}
