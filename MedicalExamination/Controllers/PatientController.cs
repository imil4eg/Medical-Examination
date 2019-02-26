using AutoMapper;
using MedicalExamination.BLL;
using MedicalExamination.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MedicalExamination.Controllers
{
    [Route("/api/[controller]")]
    public sealed class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;
        private readonly IPersonService _personService;
        private readonly IMapper _mapper;

        public PatientController(IPatientService patientService, IPersonService personService, IMapper mapper)
        {
            _patientService = patientService;
            _personService = personService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult GetPatients()
        {
            var patients = _patientService.GetAllPatients();

            return Ok(patients);
        }

        [HttpPost]
        public ActionResult GetPatient(int patientId)
        {
            var patient = _patientService.GetPatient(patientId);

            return Ok(patient);
        }

        [HttpPost]
        [Route("insert")]
        public ActionResult InsertPatient([FromBody] PatientModel model)
        {
            //_patientService.CreatePatient(patient);

            var person = Mapper.Map<PatientModel, Person>(model);
            //var person = _mapper.Map<PersonModel, Person>(model.Person);
            var patient = Mapper.Map<PatientModel, Patient>(model);
            patient.Person = person;

            return Ok();
        }
    }
}
