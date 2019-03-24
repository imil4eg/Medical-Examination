using System;
using MedicalExamination.BLL;
using Microsoft.AspNetCore.Mvc;

namespace MedicalExamination.Controllers
{
    [Route("api/[controller]")]
    public sealed class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [HttpGet]
        public ActionResult GetAppointments()
        {
            return Ok(_appointmentService.GetAllAppointments());
        }

        [HttpGet]
        [Route("getappointment")]
        public ActionResult GetAppointment(Guid id)
        {
            return Ok(this._appointmentService.GetAppointment(id));
        }

        [HttpPost]
        [Route("create")]
        public ActionResult CreateAppointment(AppointmentModel model)
        {
            try
            {
                var appointment =
                    SimpleMapper.Mapper.Map<AppointmentModel, MedicalExamination.BLL.AppointmentModel>(model);

                this._appointmentService.CreateAppointment(appointment);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("update")]
        public ActionResult UpdateAppointment(AppointmentModel model)
        {
            try
            {
                var appointment =
                    SimpleMapper.Mapper.Map<AppointmentModel, MedicalExamination.BLL.AppointmentModel>(model);

                this._appointmentService.UpdateAppointment(appointment);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("delete")]
        public ActionResult DeleteAppointment(AppointmentModel model)
        {
            try
            {
                var appointment =
                    SimpleMapper.Mapper.Map<AppointmentModel, MedicalExamination.BLL.AppointmentModel>(model);

                this._appointmentService.DeleteAppointment(appointment);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
