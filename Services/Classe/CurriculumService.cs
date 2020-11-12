using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoCurriculum.Services.Interface;
using ProjetoCurriculum.Models;
using ProjetoCurriculum.Repository.Interface;

namespace ProjetoCurriculum.Services.Classe
{
    public class CurriculumService : ICurriculumService
    {
        private readonly ICurriculumRepository curriculumRepository;
        public CurriculumService(ICurriculumRepository CurriculumRepository)
        {
            curriculumRepository = CurriculumRepository;
        }
        public async Task<Curriculum> CreateCurriculum(Curriculum curriculum)
        {
            try
            {
                curriculum.CreationDate =  DateTime.Now;
                curriculum.UpdateDate =  DateTime.Now;
                var result = await curriculumRepository.Add(curriculum);
                return result;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);

                return null;
            }
        }

        public async Task<IEnumerable<Curriculum>> GetAllCurriculum()
        {
            try
            {
                var result = await curriculumRepository.GetAll();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<Curriculum> GetCurriculumById(int id)
        {
            try
            {
                var result = await curriculumRepository.Find(id);
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<bool> DeleteCurriculum(int id)
        {
            try
            {
                await curriculumRepository.Delete(id);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Task<Curriculum> CreateBook(Curriculum book)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Curriculum>> GetAllBook()
        {
            throw new NotImplementedException();
        }

        public Task<Curriculum> GetBookById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteBook(int id)
        {
            throw new NotImplementedException();
        }
    }
}
