using System;
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

        // TODO: realize logic of appointment

        public IEnumerable<Appointment> GetAllAppointments()
        {
            return _appointmentRepository.GetAll();
        }

        public Appointment GetAppointment(Guid id)
        {
            return _appointmentRepository.GetById(id);
        }

        public void CreateAppointment(AppointmentModel appointmentModel)
        {
            //_appointmentRepository.Insert(appointment);
        }

        public void UpdateAppointment(AppointmentModel appointmentModel)
        {
            //_appointmentRepository.Update(appointment);
        }

        public void DeleteAppointment(AppointmentModel appointmentModel)
        {
            //_appointmentRepository.Delete(appointment);
        }
    }
}
