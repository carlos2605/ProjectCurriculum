using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoCurriculum.Models;

namespace ProjetoCurriculum.Services.Interface
{
    public interface ICurriculumService
    {
        Task<Curriculum> CreateCurriculum(Curriculum curriculum);
        Task<IEnumerable<Curriculum>> GetAllCurriculum();
        Task<Curriculum> GetCurriculumById(int id);
        Task<bool> DeleteCurriculum(int id);
    }
}
