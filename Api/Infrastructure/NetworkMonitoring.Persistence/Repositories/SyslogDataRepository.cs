using NetworkMonitoring.Application.Repositories;
using NetworkMonitoring.Domain.Models;
using NetworkMonitoring.Persistence.Context;

namespace NetworkMonitoring.Persistence.Repositories
{
    public class SyslogDataRepository : RepositoryBase<SyslogData>, ISyslogDataRepository
    {
        public SyslogDataRepository(NetworkMonitoringContext context) : base(context)
        {
        }
    }
}
