using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoCurriculum.Models;

namespace ProjetoCurriculum.Repository.Interface
{
    public interface IRegisterRepository
    {
        Task<Register> Add(Register register);
        Task<Register> Edit(Register register);
        Task<Register> Find(int id);
        Task<IEnumerable<Register>> GetAllByDelivery();
        Task<IEnumerable<Register>> GetAll();
        Task Delete(int id);
    }
}
