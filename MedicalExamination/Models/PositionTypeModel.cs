﻿using System;
using System.Runtime.Serialization;

namespace MedicalExamination
{
    [DataContract]
    public sealed class PositionTypeModel
    {
        [DataMember(Name = "id")]
        public Guid Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}
