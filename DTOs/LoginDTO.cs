using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCurriculum.DTOs
{
    public class LoginDTO
    {
        public string token { get; set; }
        public bool success { get; set; }

        public LoginDTO(string Token, bool Success)
        {
            token = Token;
            success = Success;
        }
    }
}
