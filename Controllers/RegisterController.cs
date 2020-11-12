using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoCurriculum.DTOs;
using ProjetoCurriculum.Services.Interface;

namespace ProjetoCurriculum.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("Bearer",Roles = "Admin")]
    public class RegisterController : ControllerBase
    {
        private readonly IRegisterService registerService;
        public RegisterController(IRegisterService RegisterService)
        {
            registerService = RegisterService;
        }
        [HttpPost]
        public async Task<object> RegisterRegister([FromBody] FormRegisterRegisterDTO register)
        {
            dynamic result = await registerService.RegisterRegister(register);

            if (result.success)
            {
                return result;
            }
            else
            {
                return BadRequest( result);
            }
        }

        [HttpGet]
        public async Task<object> GetAllCurriculumsByDelivery()
        {
            var result = registerService.GetRegister();
            if (result  != null)
            {
                return result;
            }
            else
            {
                return new
                {
                    success = false
                };
            }
        }

        [HttpPut]
        public async Task<object> ReturnRegister([FromBody] FormReturnRegisterDTO register)
        {
            dynamic result = await registerService.ReturnRegister(register);

            if (result.success)
            {
                return result;
            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}
