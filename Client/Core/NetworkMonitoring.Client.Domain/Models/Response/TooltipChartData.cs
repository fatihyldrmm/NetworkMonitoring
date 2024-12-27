namespace NetworkMonitoring.Client.Domain.Models.Response
{
    public class TooltipChartData
    {
        public string OIDName { get; set; }
        public List<SnmpDataPoint> DataPoints { get; set; }
        public string? Color { get; set; }
    }
}
