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

        [HttpPost("~/Comment/Create"),SwaggerOperation("Add new comment")]
        public IActionResult CreatePost(CreateCommentDto newPost)
        {
            if (ModelState.IsValid)
            {
                var result = _service.CreateComment(newPost);
                return Ok(result);
            }
            return BadRequest();    
        }

        [HttpDelete("~/Comment/Remove"),SwaggerOperation("Remove Comment")]
        public IActionResult RemoveComment(int id)
        {
            var result = _service.RemoveComment(id);
            if (result is true)
            {
                return NoContent();
            }

            return BadRequest();
        }

        [HttpPatch("~/Comment/Update"),SwaggerOperation("Update comment with defined id")]
        public IActionResult UpdateComment(UpdateCommentDto updateComment)
        {
            if (ModelState.IsValid)
            {
                var result = _service.UpdateComment(updateComment);

                if(result is null) return NoContent();

                return Ok(result);
            }
            return BadRequest();
        }
    }
}
