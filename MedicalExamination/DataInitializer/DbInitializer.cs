using System.Linq;
using System.Threading.Tasks;
using MedicalExamination.DAL;
using MedicalExamination.Entities;
using Microsoft.AspNetCore.Identity;

namespace MedicalExamination
{
    public sealed class DbInitializer
    {
        private readonly MedicalExaminationContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;


        public DbInitializer(MedicalExaminationContext context, UserManager<ApplicationUser> userManager, 
            RoleManager<ApplicationRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task Initialize()
        {
            //_context.Database.EnsureCreated();
            await InitRoles();
            await InitUsers();
        }

        private async Task InitUsers()
        {
            if (_context.Users.Any())
            {
                return;
            }

            var testUser = new ApplicationUser
            {
                UserName = "Test",
                Password = "TestTest1,"
            };

            var createTestUser = await _userManager.CreateAsync(testUser, testUser.Password);
            if (createTestUser.Succeeded)
            {
                await _userManager.AddToRoleAsync(testUser, "Test");
            }

            _context.SaveChanges();
        }

        private async Task InitRoles()
        {
            if (_context.Roles.Any())
            {
                return;
            }

            var testRole = new ApplicationRole
            {
                Name = "Test",
                NormalizedName = "TEST",
            };

            var createTestRole =  await _roleManager.CreateAsync(testRole);

            _context.SaveChanges();
        }
    }
}
