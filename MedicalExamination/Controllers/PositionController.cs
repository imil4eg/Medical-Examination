﻿using System;
using MedicalExamination.BLL;
using Microsoft.AspNetCore.Mvc;

namespace MedicalExamination.Controllers
{
    [Route("api/[controller]")]
    public sealed class PositionController : ControllerBase
    {
        private readonly IPositionService _positionService;

        public PositionController(IPositionService positionService)
        {
            _positionService = positionService;
        }

        [HttpGet]
        public ActionResult GetPositions()
        {
            return Ok(_positionService.GetAllPositions());
        }

        [HttpGet]
        [Route("getposition")]
        public ActionResult GetPosition(Guid positionId)
        {
            return Ok(_positionService.GetPosition(positionId));
        }

        [HttpGet]
        [Route("workerpositions")]
        public ActionResult GetWorkerPositions(int workerId)
        {
            return Ok(_positionService.GetWorkerPositions(workerId));
        }

        [HttpPost]
        [Route("create")]
        public ActionResult CreatePosition([FromBody] PositionModel model)
        {
            try
            {
                var position = SimpleMapper.Mapper.Map<PositionModel, MedicalExamination.BLL.PositionModel>(model);

                _positionService.CreatePosition(position);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("update")]
        public ActionResult UpdatePosition([FromBody] PositionModel model)
        {
            try
            {
                var position = SimpleMapper.Mapper.Map<PositionModel, MedicalExamination.BLL.PositionModel>(model);

                _positionService.UpdatePosition(position);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("delete")]
        public ActionResult DeletePosition([FromBody] PositionModel model)
        {
            try
            {
                var position = SimpleMapper.Mapper.Map<PositionModel, MedicalExamination.BLL.PositionModel>(model);

                _positionService.DeletePosition(position);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
