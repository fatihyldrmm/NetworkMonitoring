namespace NetworkMonitoring.Client.Domain.Models.Response
{
    public class SnmpDataPoint
    {
        public string OidName { get; set; }
        public string OidValue { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
