using System;
using System.Runtime.Serialization;

namespace MedicalExamination
{
    [DataContract]
    public sealed class DiseaseOutcomeModel
    {
        [DataMember(Name = "appointment_id")]
        public Guid AppointmentId { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}
