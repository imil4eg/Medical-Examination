using System.Collections.Generic;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    /// <summary>
    /// Interface for <see cref="InsuranceCompanyType"/> entity service implementation
    /// </summary>
    public interface IInsuranceCompanyTypeService
    {
        IEnumerable<InsuranceCompanyType> GetAllInsuranceCompanyTypes();
        InsuranceCompanyType GetInsuranceCompanyType(int id);
        void CreateInsuranceCompanyType(InsuranceCompanyType insuranceCompanyType);
        void UpdateInsuranceCompanyType(InsuranceCompanyType insuranceCompanyType);
        void DeleteInsuranceCompanyType(InsuranceCompanyType insuranceCompanyType);
    }
}
