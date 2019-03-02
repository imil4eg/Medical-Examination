using System.Runtime.Serialization;

namespace MedicalExamination
{
    [DataContract]
    public sealed class UserModel
    {
        [DataMember(Name = "username")]
        public string UserName { get; set; }

        [DataMember(Name = "password")]
        public string Password { get; set; }
    }
}
