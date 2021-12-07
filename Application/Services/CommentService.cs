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
            //check if post and account exists
            if (!_repository.PostExist(newComment.PostId) || !_repository.AcocuntExist(newComment.AccountId)) return null; 

            var comment = _mapper.Map<Comment>(newComment);
                comment.AccountUsername = _repository.GetUsername(newComment.AccountId);
                comment.Created = DateTime.Now;


            var result = _repository.Add(comment);

            return _mapper.Map<CommentDto>(result);
        }

        public bool RemoveComment(int id)
        {
            var comment = _repository.GetById(id);
            if (comment is not null)
            {
                _repository.Delete(comment);
                return true;
            }

            return false;
        }

        public CommentDto UpdateComment(UpdateCommentDto updateComment)
        {
            var existingComment= _repository.GetById(updateComment.CommentId);
            var accountExist = _repository.AcocuntExist(updateComment.CommentId);

            if (existingComment is null || accountExist is false) return null;

            var currentComment = _mapper.Map(updateComment, existingComment);

            _repository.Update(currentComment);

            return _mapper.Map<CommentDto>(currentComment);
        }
    }
}
