using NetworkMonitoring.Application.Repositories;
using NetworkMonitoring.Domain.Models;
using NetworkMonitoring.Persistence.Context;

namespace NetworkMonitoring.Persistence.Repositories
{
    public class TcpRepository : RepositoryBase<TcpData>, ITcpRepository
    {
        public TcpRepository(NetworkMonitoringContext context) : base(context)
        {
        }
    }
}
