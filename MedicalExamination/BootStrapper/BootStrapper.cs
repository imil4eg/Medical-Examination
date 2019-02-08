using System;
using System.Linq;
using MedicalExamination.DAL;
using Microsoft.Extensions.DependencyInjection;

namespace MedicalExamination
{
    public class BootStrapper
    {
        public static void Configure(IServiceCollection service)
        {
            var allProviderTypes = System.Reflection.Assembly.GetAssembly(typeof(UnitOfWork)).GetTypes();
                //.Where(t => t.Namespace != null && t.Namespace.Contains("MeidcalExamination.DAL"));

            foreach (var abstrct in allProviderTypes.Where(t => t.IsAbstract))
            {
                var implementaion = allProviderTypes.FirstOrDefault(c => c.IsClass && abstrct.Name == c.Name);

                if (implementaion != null)
                {
                    Type interfaceType = abstrct.GetGenericArguments()[0];
                    //service.AddTransient<typeof(interfaceType), > ()
                }
            }
        }
    }
}
