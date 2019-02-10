using System.Collections.Generic;
using MedicalExamination.DAL;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    public sealed class PositionService : IPositionService
    {
        private readonly IGenericRepository<Position> _positionRepository;

        public PositionService(IGenericRepository<Position> positionRepository)
        {
            _positionRepository = positionRepository;
        }

        public IEnumerable<Position> GetAPositions()
        {
            return _positionRepository.GetAll();
        }

        public Position GetPosition(int id)
        {
            return _positionRepository.GetById(id);
        }

        public void CreatePosition(Position position)
        {
            _positionRepository.Insert(position);
        }

        public void UpdatePosition(Position position)
        {
            _positionRepository.Update(position);
        }

        public void DeletePosition(Position position)
        {
            _positionRepository.Delete(position);
        }
    }
}
