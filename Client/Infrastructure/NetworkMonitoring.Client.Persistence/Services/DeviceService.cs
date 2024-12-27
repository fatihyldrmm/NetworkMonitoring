using Newtonsoft.Json;
using System;
using NetworkMonitoring.Client.Application.Services;
using NetworkMonitoring.Client.Domain.Models.Response;

namespace NetworkMonitoring.Client.Persistence.Services
{
    public class DeviceService : IDeviceService
    {
        private readonly HttpClient httpClient;

        public DeviceService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<string>> GetAllOidsAsync(string ipAdress)
        {
            HttpResponseMessage response = await httpClient.GetAsync($"api/Snmp/get-mib-list/{ipAdress}");
            response.EnsureSuccessStatusCode();
            string json = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<List<string>>(json);
            return data;
        }

        public async Task<ColumnChartData> GetTcpOids(string ipAdress)
        {
            if (ipAdress == null)
                ipAdress = "192.168.1.1";
            HttpResponseMessage response = await httpClient.GetAsync($"api/Snmp/get-tcp-oid/{ipAdress}");
            response.EnsureSuccessStatusCode();
            string json = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<ColumnChartData>(json);
            return data;
        }
        public async Task<ColumnChartData> GetUdpOids(string ipAdress)
        {
            if (ipAdress == null)
                ipAdress = "192.168.1.1";
            HttpResponseMessage response = await httpClient.GetAsync($"api/Snmp/get-udp-oid/{ipAdress}");
            response.EnsureSuccessStatusCode();
            string json = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<ColumnChartData>(json);
            return data;
        }
        public async Task<ColumnChartData> GetSystemOids(string ipAdress)
        {
            if (ipAdress == null)
                ipAdress = "192.168.1.1";
            HttpResponseMessage response = await httpClient.GetAsync($"api/Snmp/get-system-oid/{ipAdress}");
            response.EnsureSuccessStatusCode();
            string json = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<ColumnChartData>(json);
            return data;
        }
        public async Task<ColumnChartData> GetSnmpStatsOids(string ipAdress)
        {
            if (ipAdress == null)
                ipAdress = "192.168.1.1";
            HttpResponseMessage response = await httpClient.GetAsync($"api/Snmp/get-snmp-stats-oid/{ipAdress}");
            response.EnsureSuccessStatusCode();
            string json = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<ColumnChartData>(json);
            return data;
        }
        public async Task<ColumnChartData> GetIpOids(string ipAdress)
        {
            if (ipAdress == null)
                ipAdress = "192.168.1.1";
            HttpResponseMessage response = await httpClient.GetAsync($"api/Snmp/get-ip-oid/{ipAdress}");
            response.EnsureSuccessStatusCode();
            string json = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<ColumnChartData>(json);
            return data;
        }
        public async Task<ColumnChartData> GetInterfaceOids(string ipAdress)
        {
            if (ipAdress == null)
                ipAdress = "192.168.1.1";
            HttpResponseMessage response = await httpClient.GetAsync($"api/Snmp/get-interface-oid/{ipAdress}");
            response.EnsureSuccessStatusCode();
            string json = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<ColumnChartData>(json);
            return data;
        }
        public async Task<ColumnChartData> GetIcmpOids(string ipAdress)
        {
            if (ipAdress == null)
                ipAdress = "192.168.1.1";
            HttpResponseMessage response = await httpClient.GetAsync($"api/Snmp/get-icmp-oid/{ipAdress}");
            response.EnsureSuccessStatusCode();
            string json = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<ColumnChartData>(json);
            return data;
        }
        public async Task<ColumnChartData> GetEgpOids(string ipAdress)
        {
            if (ipAdress == null)
                ipAdress = "192.168.1.1";
            HttpResponseMessage response = await httpClient.GetAsync($"api/Snmp/get-egp-oid/{ipAdress}");
            response.EnsureSuccessStatusCode();
            string json = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<ColumnChartData>(json);
            return data;
        }
        public async Task<ColumnChartData> GetEgpCommunicationOids(string ipAdress)
        {
            if (ipAdress == null)
                ipAdress = "192.168.1.1";
            HttpResponseMessage response = await httpClient.GetAsync($"api/Snmp/get-egpcomm-oid/{ipAdress}");
            response.EnsureSuccessStatusCode();
            string json = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<ColumnChartData>(json);
            return data;
        }
        public async Task<ColumnChartData> GetEgpAtOids(string ipAdress)
        {
            if (ipAdress == null)
                ipAdress = "192.168.1.1";
            HttpResponseMessage response = await httpClient.GetAsync($"api/Snmp/get-egp-at-oid/{ipAdress}");
            response.EnsureSuccessStatusCode();
            string json = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<ColumnChartData>(json);
            return data;
        }
        public async Task<List<string>> GetOidTypes()
        {
            HttpResponseMessage response = await httpClient.GetAsync($"api/Snmp/get-oid-types");
            response.EnsureSuccessStatusCode();
            string json = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<List<string>>(json);
            return data;
        }

    }
}
