﻿using Application.Dtos.DtoAcc;
using Application.ServiceInterfaces;
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

        [HttpGet("~/Login"),SwaggerOperation(Summary ="Login")]
        public IActionResult Login(string login,string password)
        {
            var result = _service.Login(login, password);
            return Ok(result);
        }

        [HttpPost("~/Register"), SwaggerOperation(Summary ="Register account")]
        public IActionResult Register(CreateAccountDto account)
        {
            if (ModelState.IsValid)
            {
                var result = _service.Register(account);

                if (result is AccountDto) return Ok(result);

                return BadRequest("Login already is use");
            }
            return BadRequest();
        }

        [HttpGet("~/Accounts"), SwaggerOperation(Summary ="Get all accounts")]
        public IActionResult GetAccounts()
        {
            var result = _service.GetAccounts();
            return Ok(result);
        }

        [HttpDelete("~/Remove"),SwaggerOperation(Summary ="Remove account with defined id")]
        public IActionResult RemoveAccount(int id)
        {
            _service.Remove(id);
            return NoContent();
        }
    }
}
