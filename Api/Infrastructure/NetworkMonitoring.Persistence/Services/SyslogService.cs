using NetworkMonitoring.Application.Repositories;
using NetworkMonitoring.Domain.Models;
using SnmpProje.Services.Interfaces;

namespace NetworkMonitoring.Persistence.Services
{
    public class SyslogService : ISyslogService
    {
        private readonly ISyslogDataRepository _syslogDataRepository;

        public SyslogService(ISyslogDataRepository syslogDataRepository)
        {
            _syslogDataRepository = syslogDataRepository;
        }

        public Task<SyslogData> CreateSyslogDataAsync(SyslogData syslogData)
        {
            throw new NotImplementedException();
        }

        public Task<SyslogData> GetAllSyslogDataAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SyslogData> GetSyslogDataByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
