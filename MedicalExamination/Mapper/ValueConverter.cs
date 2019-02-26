using System;

namespace MedicalExamination
{
    public sealed class ValueConverter
    {
        public static dynamic Convert(Type destinationType, object value)
        {
            if (destinationType.IsEnum)
            {
                return Enum.ToObject(destinationType, value);
            }

            return System.Convert.ChangeType(value, destinationType);
        }
    }
}
