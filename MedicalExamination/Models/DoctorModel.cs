using System.Runtime.Serialization;

namespace MedicalExamination
{
    [DataContract]
    public sealed class WorkerModel
    {


        [DataMember(Name = "person")]
        public PersonModel Person { get; set; }
    }
}
