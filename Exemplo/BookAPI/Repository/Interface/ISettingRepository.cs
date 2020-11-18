using CVAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVAPI.Repository.Interface
{
    public interface ISettingRepository
    {
        Task<Setting> Add(Setting setting);
        Task<Setting> Edit(Setting setting);
        Task<Setting> Find(int id);
        Task<IEnumerable<Setting>> GetAllByDelivery();
        Task<IEnumerable<Setting>> GetAll();
        Task Delete(int id);
    }
}
