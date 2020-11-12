using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoCurriculum.Models;

namespace ProjetoCurriculum.Repository.Interface
{
    public interface ICurriculumRepository
    {
        Task<Curriculum> Add(Curriculum curriculum);
        Task<Curriculum> Find(int id);
        Task<IEnumerable<Curriculum>> GetAll();
        Task Delete(int id);
    }
}
