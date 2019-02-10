using System.Collections.Generic;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    /// <summary>
    /// Interface for <see cref="Position"/> entity
    /// </summary>
    public interface IPositionService
    {
        IEnumerable<Position> GetAPositions();
        Position GetPosition(int id);
        void CreatePosition(Position position);
        void UpdatePosition(Position position);
        void DeletePosition(Position position);
    }
}
