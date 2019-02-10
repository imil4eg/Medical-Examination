using System.Collections.Generic;
using MedicalExamination.DAL;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    public sealed class DoctorService : IDoctorService
    {
        private readonly IGenericRepository<Doctor> _doctorRepository;

        public DoctorService(IGenericRepository<Doctor> doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }
 
        public IEnumerable<Doctor> GetAllDoctors()
        {
            return _doctorRepository.GetAll();
        }

        public Doctor GetDoctor(int id)
        {
            return _doctorRepository.GetById(id);
        }

        public void CreateDoctor(Doctor doctor)
        {
            _doctorRepository.Insert(doctor);
        }

        public void UpdateDoctor(Doctor doctor)
        {
            _doctorRepository.Update(doctor);
        }

        public void DeleteDoctor(Doctor doctor)
        {
            _doctorRepository.Delete(doctor);
        }
    }
}
