using NetworkMonitoring.Application.Repositories;
using NetworkMonitoring.Domain.Models;
using NetworkMonitoring.Persistence.Context;

namespace NetworkMonitoring.Persistence.Repositories
{
    internal class DeviceRepository : RepositoryBase<Device>, IDeviceRepository
    {
        public DeviceRepository(NetworkMonitoringContext context) : base(context)
        {
        }
    }
}
