using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalExamination.Entities
{
    public sealed class Worker
    {
        [Key]
        public int PersonId { get; set; }
        [ForeignKey("PersonId")]
        public Person Person { get; set; }

        public Guid? UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
    }
}
