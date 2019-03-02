using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalExamination.Entities
{
    public sealed class ServiceHistory
    {
        [Key]
        public Guid Id { get; set; }

        public int WorkerId { get; set; }
        [ForeignKey("WorkerId")]
        public Worker Worker { get; set; }

        public int PatientId { get; set; }
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }

        public Guid ServiceTypeId { get; set; }
        [ForeignKey("ServiceTypeId")]
        public ServiceType ServiceType { get; set; }

        public string Result { get; set; }

        public string TubeNumber { get; set; }

        public string Description { get; set; }
    }
}
