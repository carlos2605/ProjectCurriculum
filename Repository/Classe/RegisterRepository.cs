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
    public class RegisterRepository : IRegisterRepository
    {
        private readonly ApplicationContext db;
        public RegisterRepository(ApplicationContext ctx)
        {
            db = ctx;
        }

        public async Task<Register> Add(Register register)
        {
            db.Registers.Add(register);
            await db.SaveChangesAsync();
            return register;
        }

        public async Task<Register> Edit(Register register)
        {
            db.Registers.Update(register);
            await db.SaveChangesAsync();
            return register;
        }
        public async Task<Register> Find(int id)
        {
            var result = await db.Registers.Where(x => x.Id == id).FirstOrDefaultAsync();
            return result;
        }

        public async Task<IEnumerable<Register>> GetAllByDelivery()
        {
            var result = await db.Registers.Where(x => x.DeliveryDate == new DateTime()).ToListAsync();
            return result;
        }
        public async Task<IEnumerable<Register>> GetAll()
        {
            var result = await db.Registers.ToListAsync();
            return result;
        }

        public async Task Delete(int id)
        {
            var result = await db.Registers.Where(x => x.Id == id).FirstOrDefaultAsync();
            db.Registers.Remove(result);
            await db.SaveChangesAsync();
        }

        

        Task<Register> IRegisterRepository.Find(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Register>> IRegisterRepository.GetAllByDelivery()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Register>> IRegisterRepository.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
