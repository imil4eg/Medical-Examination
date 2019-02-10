using System.Collections.Generic;
using MedicalExamination.DAL;
using MedicalExamination.Entities;

namespace MedicalExamination.BLL
{
    public sealed class InsuranceCompanyTypeService : IInsuranceCompanyTypeService
    {
        private readonly IGenericRepository<InsuranceCompanyType> _insuranceCompanyTypeRepository;

        public InsuranceCompanyTypeService(IGenericRepository<InsuranceCompanyType> insuranceCompanyTypeRepository)
        {
            _insuranceCompanyTypeRepository = insuranceCompanyTypeRepository;
        }

        public IEnumerable<InsuranceCompanyType> GetAllInsuranceCompanyTypes()
        {
            return _insuranceCompanyTypeRepository.GetAll();
        }

        public InsuranceCompanyType GetInsuranceCompanyType(int id)
        {
            return _insuranceCompanyTypeRepository.GetById(id);
        }

        public void CreateInsuranceCompanyType(InsuranceCompanyType insuranceCompanyType)
        {
            _insuranceCompanyTypeRepository.Insert(insuranceCompanyType);
        }

        public void UpdateInsuranceCompanyType(InsuranceCompanyType insuranceCompanyType)
        {
            _insuranceCompanyTypeRepository.Update(insuranceCompanyType);
        }

        public void DeleteInsuranceCompanyType(InsuranceCompanyType insuranceCompanyType)
        {
            _insuranceCompanyTypeRepository.Delete(insuranceCompanyType);
        }
    }
}
