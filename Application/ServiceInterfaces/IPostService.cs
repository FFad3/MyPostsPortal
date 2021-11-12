using Application.Dtos.DtoAccount.DtoPost;
using Application.Dtos.DtoPost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ServiceInterfaces
{
    public interface IPostService
    {
        IEnumerable<PostDto> GetAllPosts();
        PostDto CreatePost(CreatePostDto newPost);
    }
}
