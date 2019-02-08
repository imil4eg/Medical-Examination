using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalExamination.Entities
{
    public sealed class Position
    {
        [Key]
        public Guid Id { get; set; }

        public int DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }

        public Guid PositionId { get; set; }
        [ForeignKey("PositionId")]
        public PositionType PositionType { get; set; }
    }
}
