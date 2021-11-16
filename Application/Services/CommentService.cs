using Application.Dtos.DtoOther;
using Application.ServiceInterfaces;
using AutoMapper;
using Domain.Entities;
using Domain.RepositoryInterface;

namespace Application.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _repository;

        private readonly IMapper _mapper;

        public CommentService(ICommentRepository repository, IMapper mapper)
        {
            _repository = repository;
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
