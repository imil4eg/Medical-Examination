using System;
using MedicalExamination.BLL;
using Microsoft.AspNetCore.Mvc;

namespace MedicalExamination.Controllers
{
    [Route("api/[controller]")]
    public sealed class DiagnosisTypeController : ControllerBase
    {
        private readonly IDiagnosisTypeService _diagnosisTypeService;

        public DiagnosisTypeController(IDiagnosisTypeService diagnosisTypeService)
        {
            _diagnosisTypeService = diagnosisTypeService;
        }

        [HttpGet]
        public ActionResult GetAllDiagnosisTypes()
        {
            return Ok(_diagnosisTypeService.GetAllDiagnoseTypes());
        }

        [HttpGet]
        [Route("getdiagnosistype")]
        public ActionResult GetDiagnosisType(Guid id)
        {
            return Ok(_diagnosisTypeService.GetDiagnoseType(id));
        }

        [HttpPost]
        [Route("create")]
        public ActionResult CreateDiagnosisType([FromBody] DiagnosisTypeModel model)
        {
            try
            {
                var diagnosisType =
                    SimpleMapper.Mapper.Map<DiagnosisTypeModel, MedicalExamination.BLL.DiagnosisTypeModel>(model);

                _diagnosisTypeService.CreateDiagnoseType(diagnosisType);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("update")]
        public ActionResult UpdateDiagnosisType([FromBody] DiagnosisTypeModel model)
        {
            try
            {
                var diagnosisType =
                    SimpleMapper.Mapper.Map<DiagnosisTypeModel, MedicalExamination.BLL.DiagnosisTypeModel>(model);

                _diagnosisTypeService.UpdateDiagnoseType(diagnosisType);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("delete")]
        public ActionResult DeleteDiagnosisType([FromBody] DiagnosisTypeModel model)
        {
            try
            {
                var diagnosisType =
                    SimpleMapper.Mapper.Map<DiagnosisTypeModel, MedicalExamination.BLL.DiagnosisTypeModel>(model);

                _diagnosisTypeService.DeleteDiagnoseType(diagnosisType);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
