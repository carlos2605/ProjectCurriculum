using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCurriculum.Helpers
{
    public interface IJwtHelper
    {
        string GenerateJWT(string name, string role);
    }
}
