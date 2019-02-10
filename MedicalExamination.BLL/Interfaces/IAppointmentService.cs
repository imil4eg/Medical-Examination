using System.Collections.Generic;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    /// <summary>
    /// Interface for <see cref="Appointment"/> entity service implementation
    /// </summary>
    public interface IAppointmentService
    {
        IEnumerable<Appointment> GetAllAppointments();
        Appointment GetAppointment(int id);
        void CreateAppointment(Appointment appointment);
        void UpdateAppointment(Appointment appointment);
        void DeleteAppointment(Appointment appointment);
    }
}
