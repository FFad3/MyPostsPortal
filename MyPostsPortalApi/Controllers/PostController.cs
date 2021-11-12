using Application.Dtos.DtoPost;
using Application.ServiceInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MyPostsPortalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _service;

        public PostController(IPostService service)
        {
            _service = service;
        }

        [HttpGet("~/AllPosts"),SwaggerOperation(Summary ="Get all posts")]
        public IActionResult GetPosts()
        {
            var result = _service.GetAllPosts();
            return Ok(result);
        }

        [HttpPost("~/CreatePost"),SwaggerOperation(Summary ="Create new post")]
        public IActionResult CreatePost(CreatePostDto newPost)
        {
            if (ModelState.IsValid)
            {
                var result = _service.CreatePost(newPost);
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
