using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoCurriculum.Context;
using ProjetoCurriculum.Models;
using ProjetoCurriculum.Repository.Interface;


namespace ProjetoCurriculum.Repository.Classe
{
    public class CurriculumRepository : ICurriculumRepository
    {
        private readonly ApplicationContext db;
        public CurriculumRepository(ApplicationContext ctx)
        {
            db = ctx;
        }

        public async Task<Curriculum> Add(Curriculum curriculum)
        {
            db.Curriculums.Add(curriculum);
            await db.SaveChangesAsync();
            return curriculum;
        }

        public async Task<Curriculum> Find(int id)
        {
            var result = await db.Curriculums.Where(x => x.Id == id).FirstOrDefaultAsync();
            return result;
        }

        public async Task<IEnumerable<Curriculum>> GetAll()
        {
            var result = await db.Curriculums.ToListAsync();
            return result;
        }

        public async Task Delete(int id)
        {
            var result = await db.Curriculums.Where(x => x.Id == id).FirstOrDefaultAsync();
            db.Curriculums.Remove(result);
            await db.SaveChangesAsync();
        }

        

        Task<Curriculum> ICurriculumRepository.Find(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Curriculum>> ICurriculumRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        

    }
}
