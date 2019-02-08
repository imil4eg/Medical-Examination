namespace MedicalExamination.DAL
{
    /// <summary>
    /// Interface for Unit Of Work
    /// </summary>
    public interface IUnitOfWork
    {
        void Register(IRepository repository);
    }
}
