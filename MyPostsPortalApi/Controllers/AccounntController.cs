using Application.Dtos.DtoAccount.AccountDto;
using Application.ServiceInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MyPostsPortalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccounntController : ControllerBase
    {
        private readonly IAccountService _service;

        public AccounntController(IAccountService service)
        {
            _service = service;
        }

        [HttpPost,SwaggerOperation(Summary ="Create account")]
        public IActionResult Register(CreateAccountDto account)
        {
            var result = _service.CreatAccount(account);
            return Ok(result);
        }





        [HttpGet,SwaggerOperation(Summary ="Get all accounts")]
        public IActionResult GetAccounts()
        {
            var result = _service.GetAccounts();
            return Ok(result);
        }
    }
}
