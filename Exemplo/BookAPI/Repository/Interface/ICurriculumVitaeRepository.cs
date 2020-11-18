using CVAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVAPI.Repository.Interface
{
    public interface ICurriculumVitaeRepository
    {
        Task<CurriculumVitae> Add(CurriculumVitae curriculumVitae);
        Task<CurriculumVitae> Edit(CurriculumVitae curriculumVitae);
        Task<CurriculumVitae> Find(int id);
        Task<IEnumerable<CurriculumVitae>> GetAll();
        Task Delete(int id);
    }
}
