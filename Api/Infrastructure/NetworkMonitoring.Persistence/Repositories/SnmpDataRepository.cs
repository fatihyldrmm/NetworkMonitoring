using NetworkMonitoring.Application.Repositories;
using NetworkMonitoring.Domain.Models;
using NetworkMonitoring.Persistence.Context;

namespace NetworkMonitoring.Persistence.Repositories
{
    public class SnmpDataRepository : RepositoryBase<SnmpData>, ISnmpDataRepository
    {
        public SnmpDataRepository(NetworkMonitoringContext context) : base(context)
        {
        }
    }
}
