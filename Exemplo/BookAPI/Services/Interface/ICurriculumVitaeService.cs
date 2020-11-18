using CVAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVAPI.Services.Interface
{
    public interface ICurriculumVitaeService
    {
        Task<CurriculumVitae> CreateCurriculumVitae(CurriculumVitae curriculumVitae);
        Task<CurriculumVitae> EditCurriculumVitae(CurriculumVitae curriculumVitae);
        Task<IEnumerable<CurriculumVitae>> GetAllCurriculumVitae();
        Task<CurriculumVitae> GetCurriculumVitaeById(int id);
        Task<bool> DeleteCurriculumVitae(int id);
    }
}
