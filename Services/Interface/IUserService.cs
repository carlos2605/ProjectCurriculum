using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoCurriculum.DTOs;

namespace ProjetoCurriculum.Services.Interface
{
    public interface IUserService
    {
        Task<CreateUserDTO> CreateUser(FormRegisterUserDTO userDTO);
        Task<object> AuthenticationUser(FormLoginDTO userDTO);
    }
}
