using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalExamination.Entities
{
    public sealed class PatientDiagnos
    {
        [Key]
        public Guid Id { get; set; }

        public Guid AppointmentId { get; set; }
        [ForeignKey("AppointmentId")]
        public Appointment Appointment { get; set; }

        public Guid DiagnosId { get; set; }
        [ForeignKey("DiagnosId")]
        public DiagnosType Diagnos { get; set; }

        public bool IsMain { get; set; }
    }
}