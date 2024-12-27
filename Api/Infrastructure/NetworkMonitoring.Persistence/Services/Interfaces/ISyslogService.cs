using NetworkMonitoring.Domain.Models;

namespace SnmpProje.Services.Interfaces
{
    public interface ISyslogService
    {
        Task<SyslogData> GetAllSyslogDataAsync();
        Task<SyslogData> GetSyslogDataByIdAsync(Guid id);
        Task<SyslogData> CreateSyslogDataAsync(SyslogData syslogData);
    }
}
