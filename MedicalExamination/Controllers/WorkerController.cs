using System;
using MedicalExamination.BLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace MedicalExamination.Controllers
{
    [Route("api/[controller]")]
    public sealed class WorkerController : ControllerBase
    {
        private readonly IWorkerService _workerService;

        public WorkerController(IWorkerService workerService)
        {
            _workerService = workerService;
        }

        [HttpGet]
        public ActionResult GetWorkers()
        {
            var workers = _workerService.GetAllWorkers();

            return Ok(workers);
        }

        [HttpGet]
        [Route("getworker")]
        public ActionResult GetWorker(int workerId)
        {
            var worker = _workerService.GetWorker(workerId);

            return Ok(worker);
        }

        [HttpPost]
        public ActionResult CreateWorker(WorkerModel model)
        {
            try
            {


                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
