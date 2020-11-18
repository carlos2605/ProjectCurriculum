using CVAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVAPI.Services.Interface
{
    public interface IUserService
    {
        Task<CreateUserDTO> CreateUser(FormRegisterUserDTO userDTO);
        Task<object> AuthenticationUser(FormLoginDTO userDTO);
    }
}
