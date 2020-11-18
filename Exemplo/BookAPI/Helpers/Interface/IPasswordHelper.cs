using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVAPI.Helpers.Interface
{
    public interface IPasswordHelper
    {
        string HashPassword(string password);
        bool VerifyPasswordHash(int userID, string candidate, string userHashedPass);
    }
}
