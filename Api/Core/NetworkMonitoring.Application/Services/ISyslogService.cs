using NetworkMonitoring.Domain.Models;

namespace NetworkMonitoring.Application.Services
{
    public interface ISyslogService
    {
        Task<SyslogData> GetAllSyslogDataAsync();
        Task<SyslogData> GetSyslogDataByIdAsync(Guid id);
        Task<SyslogData> CreateSyslogDataAsync(SyslogData syslogData);
    }
}
