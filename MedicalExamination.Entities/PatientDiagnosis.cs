using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalExamination.Entities
{
    public sealed class PatientDiagnosis
    {
        [Key]
        public Guid Id { get; set; }

        public Guid AppointmentId { get; set; }
        [ForeignKey("AppointmentId")]
        public Appointment Appointment { get; set; }

        public Guid DiagnosisId { get; set; }
        [ForeignKey("DiagnosisId")]
        public DiagnosisType Diagnosis { get; set; }

        public bool IsMain { get; set; }
    }
}