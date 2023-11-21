using System.Reflection;

namespace Prohix.Api.Configuration
{
    public interface IServiceInstaller
    {
        void InstallServices(IServiceCollection services, Assembly startupProjectAssembly);
    }
}
