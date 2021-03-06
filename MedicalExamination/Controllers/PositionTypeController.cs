﻿using MedicalExamination.BLL;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MedicalExamination.Controllers
{
    [Route("api/[controller]")]
    public sealed class PositionTypeController : ControllerBase
    {
        private readonly IPositionTypeService _positionTypeService;

        public PositionTypeController(IPositionTypeService positionTypeService)
        {
            _positionTypeService = positionTypeService;
        }

        [HttpGet]
        public ActionResult GetPositionTypes()
        {
            return Ok(_positionTypeService.GetAllPositionTypes());
        }

        [HttpGet]
        [Route("getpositiontype")]
        public ActionResult GetPositionType(Guid id)
        {
            return Ok(_positionTypeService.GetPositionType(id));
        }

        [HttpPost]
        [Route("create")]
        public ActionResult CreatePositionType([FromBody] PositionTypeModel model)
        {
            try
            {
                var positionType =
                    SimpleMapper.Mapper.Map<PositionTypeModel, MedicalExamination.BLL.PositionTypeModel>(model);

                _positionTypeService.CreatePositionType(positionType);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.Message);
            }
        }

        [HttpPut]
        [Route("update")]
        public ActionResult UpdatePositionType([FromBody] PositionTypeModel model)
        {
            try
            {
                var positionType =
                    SimpleMapper.Mapper.Map<PositionTypeModel, MedicalExamination.BLL.PositionTypeModel>(model);

                _positionTypeService.UpdatePositionType(positionType);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.Message);
            }
        }

        [HttpDelete]
        [Route("delete")]
        public ActionResult DeletePositionType([FromBody] PositionTypeModel model)
        {
            try
            {
                var positionType =
                    SimpleMapper.Mapper.Map<PositionTypeModel, MedicalExamination.BLL.PositionTypeModel>(model);

                _positionTypeService.DeletePositionType(positionType);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
