using System;

namespace MedicalExamination.BLL
{
    public sealed class DiseaseOutcomeModel
    {
        public Guid AppointmentId { get; set; }

        public string Name { get; set; }
    }
}
