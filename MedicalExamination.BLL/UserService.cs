using System.Collections.Generic;
using MedicalExamination.DAL;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    public sealed class UserService : IUserService
    {
        private readonly IGenericRepository<ApplicationUser> _userRepository;

        public UserService(IGenericRepository<ApplicationUser> userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<ApplicationUser> GetAllUsers()
        {
            return _userRepository.GetAll();
        }

        public ApplicationUser GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void CreateUser(ApplicationUser user)
        {
            _userRepository.Insert(user);
        }

        public void UpdateUser(ApplicationUser user)
        {
            _userRepository.Update(user);
        }

        public void DeleteUser(ApplicationUser user)
        {
            _userRepository.Delete(user);
        }
    }
}
