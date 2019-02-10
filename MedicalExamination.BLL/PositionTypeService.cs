using System.Collections.Generic;
using MedicalExamination.DAL;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    public sealed class PositionTypeService : IPositionTypeService
    {
        private readonly IGenericRepository<PositionType> _positionTypeRepository;

        public PositionTypeService(IGenericRepository<PositionType> positionTypeRepository)
        {
            _positionTypeRepository = positionTypeRepository;
        }

        public IEnumerable<PositionType> GetAllPositionTypes()
        {
            return _positionTypeRepository.GetAll();
        }

        public PositionType GetPositionType(int id)
        {
            return _positionTypeRepository.GetById(id);
        }

        public void CreatePositionType(PositionType positionType)
        {
            _positionTypeRepository.Insert(positionType);
        }

        public void UpdatePositionType(PositionType positionType)
        {
            _positionTypeRepository.Update(positionType);
        }

        public void DeletePositionType(PositionType positionType)
        {
            _positionTypeRepository.Delete(positionType);
        }
    }
}
