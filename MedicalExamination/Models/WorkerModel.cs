using System.Runtime.Serialization;

namespace MedicalExamination
{
    [DataContract]
    public sealed class WorkerModel
    {
        [DataMember(Name = "user")]
        public UserModel User { get; set; }

        [DataMember(Name = "person")]
        public PersonModel Person { get; set; }
    }
}
