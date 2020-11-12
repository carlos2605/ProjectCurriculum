using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoCurriculum.DTOs;
using ProjetoCurriculum.Models;

namespace ProjetoCurriculum.Services.Interface
{
    public interface IRegisterService
    {
        Task<object> RegisterRegister(FormRegisterRegisterDTO registerDTO);
        Task<object> ReturnRegister(FormReturnRegisterDTO registerDTO);
        Task<IEnumerable<Register>> GetRegister();
    }
}
