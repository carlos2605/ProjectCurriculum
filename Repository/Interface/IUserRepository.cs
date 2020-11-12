using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoCurriculum.Models;

namespace ProjetoCurriculum.Repository.Interface
{
    public interface IUserRepository
    {
        Task<User> Add(User user);
        Task<User> Find(int id);
        Task<User> FindByEmail(String email);
        Task<IEnumerable<User>> GetAll();
        Task Delete(int id);
    }
}
