using AutoMapper;
using MedicalExamination.Entities;

namespace MedicalExamination
{
    internal sealed class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser, LoginModel>();
            CreateMap<Patient, PatientModel>();
            CreateMap<Person, PersonModel>();
        }
    }
}
