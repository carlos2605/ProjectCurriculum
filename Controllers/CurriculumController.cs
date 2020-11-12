using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoCurriculum.Models;
using ProjetoCurriculum.Services.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjetoCurriculum.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurriculumController : ControllerBase
    {
        private readonly ICurriculumService curriculumService;
        public CurriculumController(ICurriculumService CurriculumService)
        {
            curriculumService = CurriculumService;
        }

        [HttpGet]
        [Authorize("Bearer")]
        public async Task<object> GetAllCurriculum()
        {
            var result = await curriculumService.GetAllCurriculum();

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
        public async Task<object> GetCurriculum(int Id)
        {
            var result = await curriculumService.GetCurriculumById(Id);

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

        [HttpPost]
        [Authorize("Bearer")]
        public async Task<object> CreateCurriculum([FromBody] Curriculum curriculum)
        {
            var result = await curriculumService.CreateCurriculum(curriculum);

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
        public async Task<object> DeleteCurriculum(int Id)
        {
            var result = await curriculumService.DeleteCurriculum(Id);

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
