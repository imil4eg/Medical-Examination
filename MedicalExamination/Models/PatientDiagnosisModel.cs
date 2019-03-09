using System;
using System.Runtime.Serialization;

namespace MedicalExamination.Models
{
    [DataContract]
    public sealed class PatientDiagnosisModel
    {
        [DataMember(Name = "id")]
        public Guid Id { get; set; }

        [DataMember(Name = "appointment_id")]
        public Guid AppointmentId { get; set; }

        [DataMember(Name = "diagnosis_id")]
        public Guid DiagnosisId { get; set; }

        [DataMember(Name = "is_main")]
        public bool IsMain { get; set; }
    }
}
