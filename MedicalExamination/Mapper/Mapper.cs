using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MedicalExamination
{
    public sealed class Mapper
    {
        public static TDestination Map<TSource, TDestination>(TSource sourceModel)
        {
            var destinationModel = (TDestination) Activator.CreateInstance(typeof(TDestination));

            Dictionary <string, PropertyInfo> properties = sourceModel.GetType().GetProperties()
                .ToDictionary(p => p.Name);

            foreach (var destinationProperty in destinationModel.GetType().GetProperties())
            {
                PropertyInfo sourcePropertyInfo;
                if(!properties.TryGetValue(destinationProperty.Name, out sourcePropertyInfo))
                    continue;

                var convertedToPropertyTypeValue = ValueConverter.Convert(destinationProperty.PropertyType,
                    sourcePropertyInfo.GetValue(sourceModel));
                destinationProperty.SetValue(destinationModel, convertedToPropertyTypeValue);
            }

            return (TDestination) destinationModel;
        }
    }
}
