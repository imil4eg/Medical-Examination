using System;
using System.Runtime.Serialization;

namespace MedicalExamination
{
    [DataContract]
    public sealed class UserModel
    {
        [DataMember(Name = "id")]
        public Guid Id { get; set; }

        [DataMember(Name = "username")]
        public string UserName { get; set; }

        [DataMember(Name = "password")]
        public string Password { get; set; }
    }
}
