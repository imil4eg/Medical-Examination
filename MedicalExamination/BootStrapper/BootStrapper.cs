using System.Linq;
using MedicalExamination.DAL;
using Microsoft.Extensions.DependencyInjection;

namespace MedicalExamination
{
    public class BootStrapper
    {
        public static void Configure(IServiceCollection services)
        {

            var allProviderTypes = System.Reflection.Assembly.GetAssembly(typeof(GenericRepository<>))
                .GetTypes();
            //.Where(t => t.Namespace != null && t.Namespace.Contains("MeidcalExamination.DAL"));
            //builder.RegisterGeneric(typeof(IGenericRepository<>))
            //builder.RegisterAssemblyTypes(allProviderTypes)
            //    .Where(t => t.Name.EndsWith("Repository") && t.IsClass)
            //    .As<IGenericRepository<,>>();

            foreach (var implementation in allProviderTypes.Where(t => t.Name.EndsWith("Repository") && t.IsClass))
            {
                var abstrcts = implementation.GetInterfaces();

                if (abstrcts.Length > 0)
                {
                    services.AddTransient(abstrcts[0], implementation);
                    //services.AddScoped(abstrcts[0], implementation);
                }

                //if (implementaion != null)
                //{ 
                //    Type interfaceType = abstrct.GetGenericArguments()[0];
                //    services.AddScoped(abstrct, implementaion);
                //}
            }
        }
    }
}
