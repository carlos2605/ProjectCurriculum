using CVAPI.Models;
using CVAPI.Repository.Interface;
using CVAPI.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVAPI.Services.Class
{
    public class CurriculumVitaeService : ICurriculumVitaeService
    {

        private readonly ICurriculumVitaeRepository curriculumVitaeRepository;

        public CurriculumVitaeService(ICurriculumVitaeRepository CurriculumVitaeRepository)
        {
            curriculumVitaeRepository = CurriculumVitaeRepository;
        }

        public async Task<CurriculumVitae> CreateCurriculumVitae(CurriculumVitae curriculumVitae)
        {
            try
            {
                curriculumVitae.CreationDate = DateTime.Now;
                curriculumVitae.UpdateDate = DateTime.Now;
                var result = await curriculumVitaeRepository.Add(curriculumVitae);
                return curriculumVitae;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        public async Task<CurriculumVitae> EditCurriculumVitae(CurriculumVitae curriculumVitae)
        {
            try
            {
                curriculumVitae.UpdateDate = DateTime.Now;
                var result = await curriculumVitaeRepository.Edit(curriculumVitae);
                return curriculumVitae;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        public async Task<IEnumerable<CurriculumVitae>> GetAllCurriculumVitae()
        {
            try
            {
                var result = await curriculumVitaeRepository.GetAll();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<CurriculumVitae> GetCurriculumVitaeById(int id)
        {
            try
            {
                var result = await curriculumVitaeRepository.Find(id);
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<bool> DeleteCurriculumVitae(int id)
        {
            try
            {
                await curriculumVitaeRepository.Delete(id);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
