using Application.Dtos.DtoAccount.DtoPost;
using Application.Dtos.DtoPost;
using Application.ServiceInterfaces;
using AutoMapper;
using Domain.Entities;
using Domain.RepositoryInterface;

namespace Application.Services
{
    public class PostService : IPostService
    {
        private readonly IMapper _mapper;
        private readonly IPostRepository _repository;

        public PostService(IMapper mapper, IPostRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public PostDto CreatePost(CreatePostDto newPost)
        {
            var post = _mapper.Map<Post>(newPost);
            post.Created = DateTime.Now;

            var result = _repository.Add(post);

            return _mapper.Map<PostDto>(result);
        }

        public IEnumerable<PostDto> GetAllPosts()
        {
           var result = _repository.GetAll();
           return _mapper.Map<IEnumerable<PostDto>>(result);
        }
    }
}
