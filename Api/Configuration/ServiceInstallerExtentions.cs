using System.Reflection;

namespace Prohix.Api.Configuration
{
    public static class ServiceInstallerExtentions
    {
        public static void InstallServicesInAssemblies
            (this IServiceCollection services)
        {
            var startupProjectAssembly = Assembly.GetCallingAssembly();

            var assemblies = new[] { startupProjectAssembly, Assembly.GetExecutingAssembly() };

            var installers = assemblies.SelectMany(a => a.GetExportedTypes())
                .Where(c => c.IsClass
                            && !c.IsAbstract
                            && c.IsPublic && typeof(IServiceInstaller).IsAssignableFrom(c))
                .Select(Activator.CreateInstance).Cast<IServiceInstaller>().ToList();

            installers.ForEach(i => i.InstallServices(services, startupProjectAssembly));

        }
    }
}
