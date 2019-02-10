using System.Collections.Generic;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    /// <summary>
    /// Interface for <see cref="PositionType"/> entity service implementation
    /// </summary>
    public interface IPositionTypeService
    {
        IEnumerable<PositionType> GetAllPositionTypes();
        PositionType GetPositionType(int id);
        void CreatePositionType(PositionType positionType);
        void UpdatePositionType(PositionType positionType);
        void DeletePositionType(PositionType positionType);
    }
}
