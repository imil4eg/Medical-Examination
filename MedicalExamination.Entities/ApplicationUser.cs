using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace MedicalExamination.Entities
{
    public sealed class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            Id = Guid.NewGuid();
        }

        [Required]
        public override string UserName { get; set; }
        
        [Required]
        public string Password { get; set; }
    }
}
