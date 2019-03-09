using System;
using MedicalExamination.BLL;
using Microsoft.AspNetCore.Mvc;

namespace MedicalExamination.Controllers
{
    [Route("api/[controller]")]
    public sealed class PatientDiagnosisController : ControllerBase
    {
        private readonly IPatientDiagnosisService _patientDiagnosisService;

        public PatientDiagnosisController(IPatientDiagnosisService patientDiagnosisService)
        {
            _patientDiagnosisService = patientDiagnosisService;
        }

        [HttpGet]
        public ActionResult GetAllPatientDiagnosis()
        {
            return Ok(_patientDiagnosisService.GetAllPatientDiagnosis());
        }

        [HttpGet]
        [Route("patientdiagnosis")]
        public ActionResult GetPatientDiagnosis(Guid diagnosisId)
        {
            return Ok(_patientDiagnosisService.GetPatientDiagnosis(diagnosisId));
        }

        [HttpGet]
        [Route("appointmentdiagnosis")]
        public ActionResult GetAppointmentDiagnosis(Guid appointmentId)
        {
            return Ok(_patientDiagnosisService.GetAllAppointmentDiagnosis(appointmentId));
        }

        [HttpPost]
        [Route("create")]
        public ActionResult CreatePatientDiagnosis(PatientDiagnosisModel model)
        {
            try
            {
                var diagnosis =
                    SimpleMapper.Mapper.Map<PatientDiagnosisModel, MedicalExamination.BLL.PatientDiagnosisModel>(model);

                _patientDiagnosisService.CreatePatientDiagnosis(diagnosis);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("update")]
        public ActionResult UpdatePatientDiagnosis(PatientDiagnosisModel model)
        {
            try
            {
                var diagnosis = SimpleMapper.Mapper
                    .Map<PatientDiagnosisModel, MedicalExamination.BLL.PatientDiagnosisModel>(model);

                _patientDiagnosisService.UpdatePatientDiagnosis(diagnosis);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("delete")]
        public ActionResult DeletePatientDiagnosis(PatientDiagnosisModel model)
        {
            try
            {
                var diagnosis = SimpleMapper.Mapper
                    .Map<PatientDiagnosisModel, MedicalExamination.BLL.PatientDiagnosisModel>(model);

                _patientDiagnosisService.DeletePatientDiagnosis(diagnosis);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
