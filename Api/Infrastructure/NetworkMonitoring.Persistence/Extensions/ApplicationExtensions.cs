using Microsoft.Extensions.DependencyInjection;
using NetworkMonitoring.Api.Persistence.BackgroundServices;
using NetworkMonitoring.Api.Persistence.Context;
using NetworkMonitoring.Api.Persistence.MongoDB;
using NetworkMonitoring.Application.Repositories;
using NetworkMonitoring.Persistence.Repositories;
using NetworkMonitoring.Persistence.Services;
using SnmpProje.Services.Interfaces;

namespace NetworkMonitoring.Persistence.Extensions
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IDeviceRepository, DeviceRepository>();
            services.AddScoped<ISnmpDataRepository, SnmpDataRepository>();
            services.AddScoped<ISyslogDataRepository, SyslogDataRepository>();
            services.AddScoped<ITcpRepository, TcpRepository>();
            services.AddScoped<IDeviceService, DeviceService>();
            services.AddScoped<ISnmpService, SnmpService>();
            services.AddScoped<ISyslogService, SyslogService>();
            services.AddSingleton<MongoDBContext>();
            //services.AddHostedService<SnmpDataCollectorService>();
            services.AddSingleton<SnmpRepository>();
            return services;
        }
    }
}
