using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ProjetoCurriculum.DTOs;
using ProjetoCurriculum.Models;
using ProjetoCurriculum.Repository.Interface;
using ProjetoCurriculum.Services.Interface;

namespace ProjetoCurriculum.Services.Classe
{
    
    public class RegisterService : IRegisterService
    {
        private readonly IRegisterRepository registerRepository;
        private readonly ICurriculumRepository curriculumRepository;
        private readonly IUserRepository userRepository;
        public RegisterService(
            IRegisterRepository RegisterRepository,
            ICurriculumRepository CurriculumRepository,
            IUserRepository UserRepository
        )
        {
            registerRepository = RegisterRepository;
            curriculumRepository = CurriculumRepository;
            userRepository = UserRepository;

        }

        public async Task<object> RegisterRegister(FormRegisterRegisterDTO registerDTO)
        {
            try
            {
                Register register = new Register();

                register.Curriculums = await curriculumRepository.Find(registerDTO.idCurriculum);
                register.Users = await userRepository.Find(registerDTO.idUser);
                register.LoanDate = DateTime.Now;
                register.ExpectedDate = DateTime.Now.AddDays(7);

                var result = await registerRepository.Add(register);

                if(result != null)
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
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return new
                {
                    success = false
                };
            }
        }

        public async Task<object> ReturnRegister(FormReturnRegisterDTO registerDTO)
        {
            try
            {
                var register = await registerRepository.Find(registerDTO.idRegister);
                register.DeliveryDate = registerDTO.DeliveryDate;

                

                var result = await registerRepository.Edit(register);

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
        public async Task<IEnumerable<Register>> GetRegister()
        {
            try
            {
                var result = await registerRepository.GetAllByDelivery();

                return result;
            }
            catch(Exception ex)
            {
                return null;
            }
            

        }

        
    }
}
