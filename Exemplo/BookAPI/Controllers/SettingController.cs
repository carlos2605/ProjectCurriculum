using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVAPI.DTOs;
using CVAPI.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CVAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize("Bearer", Roles = "Admin")]
    public class SettingController : ControllerBase
    {
        private readonly ISettingService settingService;
        public SettingController(ISettingService SettingService)
        {
            settingService = SettingService;
        }

        [HttpPost]
        public async Task<object> RegisterSetting([FromBody] FormRegisterSettingDTO setting)
        {
            dynamic result = await settingService.RegisterSetting(setting);

            if (result.success)
            {
                return result;
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpGet]
        public async Task<object> GetAllCurriculumsByDelivery()
        {
            var result = await settingService.GetSetting();

            if (result != null)
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
        public async Task<object> ReturnSetting([FromBody] FormReturnSettingDTO setting)
        {
            dynamic result = await settingService.ReturnSetting(setting);

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
