using CVAPI.DTOs;
using CVAPI.Models;
using CVAPI.Repository.Interface;
using CVAPI.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVAPI.Services.Class
{
    public class SettingService : ISettingService
    {
        private readonly ISettingRepository settingRepository;
        private readonly IUserRepository userRepository;
        private readonly ICurriculumVitaeRepository curriculumVitaeRepository;
        public SettingService(
            ISettingRepository SettingRepository,
            ICurriculumVitaeRepository CurriculumVitaeRepository,
            IUserRepository UserRepository
        )
        {
            settingRepository = SettingRepository;
            curriculumVitaeRepository = CurriculumVitaeRepository;
            userRepository = UserRepository;
        }

        public async Task<object> RegisterSetting(FormRegisterSettingDTO settingDTO)
        {
            try
            {
                Setting setting = new Setting();

                setting.CurriculumVitae = await curriculumVitaeRepository.Find(settingDTO.idCurriculumVitae);
                setting.User = await userRepository.Find(settingDTO.idUser);
                setting.AdmissionDate = DateTime.Now;

                var result = await settingRepository.Add(setting);

                if (result != null)
                {
                    return new
                    {
                        success = true
                    };
                }
                else
                {
                    return new
                    {
                        success = false
                    };
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return new
                {
                    success = false
                };
            }
        }

        public async Task<object> ReturnSetting(FormReturnSettingDTO settingDTO)
        {
            try
            {
                var setting = await settingRepository.Find(settingDTO.idSetting);
                setting.ResignationDate = settingDTO.ResignationDate;

                var result = await settingRepository.Edit(setting);

                if (result != null)
                {
                    return new
                    {
                        success = true
                    };
                }
                else
                {
                    return new
                    {
                        success = false
                    };
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return new
                {
                    success = false
                };
            }
        }

        public async Task<IEnumerable<Setting>> GetSetting()
        {
            try
            {
                var result = await settingRepository.GetAllByDelivery();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
