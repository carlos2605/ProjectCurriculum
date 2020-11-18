using CVAPI.Context;
using CVAPI.Models;
using CVAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVAPI.Repository.Class
{
    public class CurriculumVitaeRepository : ICurriculumVitaeRepository
    {
        private readonly ApplicationContext db;
        public CurriculumVitaeRepository(ApplicationContext ctx)
        {
            db = ctx;
        }

        public async Task<CurriculumVitae> Add(CurriculumVitae curriculumVitae)
        {
            db.CurriculumVitae.Add(curriculumVitae);
            await db.SaveChangesAsync();
            return curriculumVitae;
        }

        public async Task<CurriculumVitae> Edit(CurriculumVitae curriculumVitae)
        {
            db.CurriculumVitae.Update(curriculumVitae);
            await db.SaveChangesAsync();
            return curriculumVitae;
        }
        public async Task<CurriculumVitae> Find(int id)
        {
            var result = await db.CurriculumVitae.Where(x => x.Id == id).FirstOrDefaultAsync();
            return result;
        }

        public async Task<IEnumerable<CurriculumVitae>> GetAll()
        {
            var result = await db.CurriculumVitae.ToListAsync();
            return result;
        }

        public async Task Delete(int id)
        {
            var result = await db.CurriculumVitae.Where(x => x.Id == id).FirstOrDefaultAsync();
            db.CurriculumVitae.Remove(result);
            await db.SaveChangesAsync();
        }
    }
}