using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVAPI.Models;
using CVAPI.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CVAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurriculumVitaeController : ControllerBase
    {
        private readonly ICurriculumVitaeService curriculumVitaeService;
        public CurriculumVitaeController(ICurriculumVitaeService CurriculumVitaeService)
        {
            curriculumVitaeService = CurriculumVitaeService;
        }

        [HttpPost]
        [Authorize("Bearer")]
        public async Task<object> CreateCurriculumVitae([FromBody] CurriculumVitae curriculumVitae)
        {
            var result = await curriculumVitaeService.CreateCurriculumVitae(curriculumVitae);
            if (result != null)
            {
                return new
                {
                    success = true,
                    data = result
                };
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPut]
        [Authorize("Bearer")]
        public async Task<object> EditCurriculumVitae([FromBody] CurriculumVitae curriculumVitae)
        {
            var result = await curriculumVitaeService.EditCurriculumVitae(curriculumVitae);
            if (result != null)
            {
                return new
                {
                    success = true,
                    data = result
                };
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Authorize("Bearer")]
        public async Task<object> GetAllCurriculumVitae()
        {
            var result = await curriculumVitaeService.GetAllCurriculumVitae();
            if (result != null)
            {
                return new
                {
                    success = true,
                    data = result
                };
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("{Id}")]
        [Authorize("Bearer")]
        public async Task<object> GetCurriculumVitae(int Id)
        {
            var result = await curriculumVitaeService.GetCurriculumVitaeById(Id);
            if (result != null)
            {
                return new
                {
                    success = true,
                    data = result
                };
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete("{Id}")]
        [Authorize("Bearer")]
        public async Task<object> DeteleCurriculumVitae(int Id)
        {
            var result = await curriculumVitaeService.DeleteCurriculumVitae(Id);
            if (result)
            {
                return new
                {
                    success = true
                };
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
