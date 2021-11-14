using Application.Dtos.DtoOther;
using Application.Dtos.DtoPost;
using Application.ServiceInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MyPostsPortalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _service;
        public CommentController(ICommentService service)
        {
            _service = service;
        }

        [HttpPost("~/Create"),SwaggerOperation("Add new comment")]
        public IActionResult CreatePost(CreateCommentDto newPost)
        {
            if (ModelState.IsValid)
            {
                var result = _service.CreateComment(newPost);
                return Ok(result);
            }
            return BadRequest();    
        }
    }
}
