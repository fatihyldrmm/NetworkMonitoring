namespace NetworkMonitoring.Application.OidLists
{
    public class TcpOids
    {
        public static string TcpActiveOpens => "1.3.6.1.2.1.6.1.0";
        public static string TcpPassiveOpens => "1.3.6.1.2.1.6.2.0";
        public static string TcpAttemptFails => "1.3.6.1.2.1.6.3.0";
        public static string TcpEstabResets => "1.3.6.1.2.1.6.4.0";
        public static string TcpCurrEstab => "1.3.6.1.2.1.6.5.0";
        public static string TcpInSegs => "1.3.6.1.2.1.6.6.0";
        public static string TcpOutSegs => "1.3.6.1.2.1.6.7.0";
        public static string TcpRetransSegs => "1.3.6.1.2.1.6.8.0";
        public static string TcpInErrs => "1.3.6.1.2.1.6.9.0";
        public static string TcpOutRsts => "1.3.6.1.2.1.6.10.0";
        public static string TcpInCsumErrors => "1.3.6.1.2.1.6.11.0";
        public static string TcpOutCsumErrors => "1.3.6.1.2.1.6.12.0";
        public static string TcpHCInSegs => "1.3.6.1.2.1.6.13.0";
        public static string TcpHCOutSegs => "1.3.6.1.2.1.6.14.0";
        public static string TcpHCInOctets => "1.3.6.1.2.1.6.15.0";
    }
}
