using System;

namespace SimpleMapper
{
    public sealed class ValueConverter
    {
        public static dynamic Convert(Type destinationType, object value)
        {
            if (destinationType.IsEnum)
            {
                return Enum.ToObject(destinationType, value);
            }

            if (destinationType.IsClass)
            {
                return null;
            }

            return System.Convert.ChangeType(value, destinationType);
        }
    }
}
