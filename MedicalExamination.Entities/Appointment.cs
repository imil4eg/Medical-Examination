using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalExamination.Entities
{
    public sealed class Appointment
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public int DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }

        [Required]
        public int PatientId { get; set; }
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }

        public Guid DiseaseOutcomeId { get; set; }
        [ForeignKey("DiseaseOutcomeId")]
        public DiseaseOutcomeType Outcome { get; set; }

        [Required]
        public Guid ExaminationResultId { get; set; }
        [ForeignKey("ExaminationResultId")]
        public ExaminationResultType ExaminationResult { get; set; }

        [Required]
        public DateTime EndDate { get; set; }
    }
}
