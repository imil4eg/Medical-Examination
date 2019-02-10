using System.Collections.Generic;
using MedicalExamination.DAL;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    /// <summary>
    /// Class to data access layer for <see cref="Appointment"/> entity
    /// </summary>
    public sealed class AppointmentService : IAppointmentService
    {
        private readonly IGenericRepository<Appointment> _appointmentRepository;

        public AppointmentService(IGenericRepository<Appointment> appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public IEnumerable<Appointment> GetAllAppointments()
        {
            return _appointmentRepository.GetAll();
        }

        public Appointment GetAppointment(int id)
        {
            return _appointmentRepository.GetById(id);
        }

        public void CreateAppointment(Appointment appointment)
        {
            _appointmentRepository.Insert(appointment);
        }

        public void UpdateAppointment(Appointment appointment)
        {
            _appointmentRepository.Update(appointment);
        }

        public void DeleteAppointment(Appointment appointment)
        {
            _appointmentRepository.Delete(appointment);
        }
    }
}
