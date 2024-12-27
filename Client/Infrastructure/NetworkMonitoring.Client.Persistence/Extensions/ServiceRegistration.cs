using Microsoft.Extensions.DependencyInjection;
using NetworkMonitoring.Client.Application.Services;
using NetworkMonitoring.Client.Persistence.Services;

namespace NetworkMonitoring.Client.Persistence.Extensions
{
    public static class ServiceRegistration
    {
        public static void AddServiceRegistration(this IServiceCollection services)
        {
            services.AddScoped<IDeviceService, DeviceService>();
        }
    }
}
