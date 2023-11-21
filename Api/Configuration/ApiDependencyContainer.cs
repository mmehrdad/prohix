using Prohix.Api.Injections;
using Prohix.Infrastracture.DBContexts;

namespace Prohix.Api.Configuration
{
    public static class ApiDependencyContainer
    {

        public static IServiceCollection InjectDependency(this IServiceCollection services)
        {

            services.AddScoped<DataBaseContext>();
            services.AddScoped(typeof(Lazy<>), typeof(Lazy<>));
            services.RegisterScopeds();

            services.InstallServicesInAssemblies();



            return services;

        }

    }
    internal class Lazier<T> : Lazy<T> where T : class
    {
        public Lazier(IServiceProvider provider)
            : base(() => provider.GetRequiredService<T>())
        {
        }
    }
}
