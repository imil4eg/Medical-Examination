using System;

namespace MedicalExamination.BLL
{
    public sealed class PatientModel
    {
        public int Id { get; set; }

        public string InsuranceNumber { get; set; }

        public Guid InsuranceCompanyId { get; set; }

        public PersonModel Person { get; set; }
    }
}
