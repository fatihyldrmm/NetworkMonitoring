

using NetworkMonitoring.Domain.Models;

namespace SnmpProje.Services.Interfaces
{
    public interface ISnmpService
    {
        Task<Dictionary<string, string>> GetSnmpDataAsync(string ipAddress, string community, List<string> oids);
        Task<List<SnmpData>> GetAllSnmpDataAsync();
        Task<SnmpData> GetSnmpDataByIdAsync(Guid id);
        Task<SnmpData> CreateSnmpDataAsync(SnmpData snmpData);
        Task<List<string>> GetDeviceMibList(string host, string community);
        Task<List<string>> GetTcpOidData(string host, string community);

    }

}
