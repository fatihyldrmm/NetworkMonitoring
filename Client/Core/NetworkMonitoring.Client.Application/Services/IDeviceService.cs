using NetworkMonitoring.Client.Domain.Models.Response;

namespace NetworkMonitoring.Client.Application.Services
{
    public interface IDeviceService
    {
        public Task<List<string>> GetAllOidsAsync(string ipAdress);
        public Task<ColumnChartData> GetTcpOids(string ipAdress);
        public Task<ColumnChartData> GetUdpOids(string ipAdress);
        public Task<ColumnChartData> GetSystemOids(string ipAdress);
        public Task<ColumnChartData> GetSnmpStatsOids(string ipAdress);
        public Task<ColumnChartData> GetIpOids(string ipAdress);
        public Task<ColumnChartData> GetInterfaceOids(string ipAdress);
        public Task<ColumnChartData> GetIcmpOids(string ipAdress);
        public Task<ColumnChartData> GetEgpOids(string ipAdress);
        public Task<ColumnChartData> GetEgpCommunicationOids(string ipAdress);
        public Task<ColumnChartData> GetEgpAtOids(string ipAdress);
        public Task<List<string>> GetOidTypes();
    }
}
