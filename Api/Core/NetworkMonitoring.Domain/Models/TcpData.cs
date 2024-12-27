namespace NetworkMonitoring.Domain.Models
{
    public class TcpData : BaseEntity
    {
        public int DeviceNo { get; set; }
        public TimeSpan Time { get; set; }
        public string TcpRtoAlgorithm { get; set; } = string.Empty;
        public string TcpRtoMin { get; set; } = string.Empty;
        public string TcpRtoMax { get; set; } = string.Empty;
        public string TcpMaxConn { get; set; } = string.Empty;
        public string TcpActiveOpens { get; set; } = string.Empty;
        public string TcpPassiveOpens { get; set; } = string.Empty;
        public string TcpAttemptFails { get; set; } = string.Empty;
        public string TcpEstabResets { get; set; } = string.Empty;
        public string TcpCurrEstab { get; set; } = string.Empty;
        public string TcpInSegs { get; set; } = string.Empty;
        public string TcpOutSegs { get; set; } = string.Empty;
        public string TcpRetransSegs { get; set; } = string.Empty;
        public string TcpConnTable { get; set; } = string.Empty;
        public string TcpInErrs { get; set; } = string.Empty;
        public string TcpOutRsts { get; set; } = string.Empty;
    }


}
