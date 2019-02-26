using System;
using System.Runtime.Serialization;

namespace MedicalExamination
{
    [DataContract]
    public sealed class PatientModel
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "lastname")]
        public string LastName { get; set; }

        [DataMember(Name = "firstname")]
        public string FirstName { get; set; }

        [DataMember(Name = "middlename")]
        public string MiddleName { get; set; }

        [DataMember(Name = "gender")]
        public byte Gender { get; set; }

        [DataMember(Name = "birthdate")]
        public DateTime BirthDate { get; set; }

        [DataMember(Name = "passport_number")]
        public string PassportNumber { get; set; }

        [DataMember(Name = "passport_series")]
        public string PassportSeries { get; set; }

        [DataMember(Name = "passport_issue_date")]
        public DateTime PassportIssueDate { get; set; }

        [DataMember(Name = "passport_issue_place_id")]
        public Guid PassportIssuePlaceId { get; set; }

        [DataMember(Name = "insurance_number")]
        public string InsuranceNumber { get; set; }
        
        [DataMember(Name = "insurance_company_id")]
        public Guid InsuranceCompanyId { get; set; }
    }
}
