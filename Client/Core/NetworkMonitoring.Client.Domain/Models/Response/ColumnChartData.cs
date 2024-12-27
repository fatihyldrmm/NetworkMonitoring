namespace NetworkMonitoring.Client.Domain.Models.Response
{
    public class ColumnChartData
    {
        public string OidType { get; set; }
        public List<SnmpDataPoint> DataPoints { get; set; }
    }

}
