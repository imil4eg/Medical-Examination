using System.Collections.Generic;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    /// <summary>
    /// Interface for <see cref="ApplicationUser"/> entity service implementation
    /// </summary>
    public interface IUserService
    {
        IEnumerable<ApplicationUser> GetAllUsers();
        ApplicationUser GetUserById(int id);
        void CreateUser(ApplicationUser user);
        void UpdateUser(ApplicationUser user);
        void DeleteUser(ApplicationUser user);
    }
}
