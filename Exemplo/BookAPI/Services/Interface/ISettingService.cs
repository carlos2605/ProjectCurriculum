using CVAPI.DTOs;
using CVAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVAPI.Services.Interface
{
    public interface ISettingService
    {
        Task<object> RegisterSetting(FormRegisterSettingDTO settingDTO);
        Task<object> ReturnSetting(FormReturnSettingDTO settingDTO);
        Task<IEnumerable<Setting>> GetSetting();
    }
}
