using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalExamination.Entities
{
    /// <summary>
    /// Dictionary of disease outcomes
    /// </summary>
    public sealed class DiseaseOutcomeType
    {
        public Guid AppointmentId { get; set; }
        [ForeignKey("AppointmentId")]
        public Appointment Appointment { get; set; }

        public string Name { get; set; }
    }
}