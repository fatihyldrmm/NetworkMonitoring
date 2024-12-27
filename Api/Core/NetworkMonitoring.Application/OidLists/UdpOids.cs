namespace NetworkMonitoring.Application.OidLists
{
    public class UdpOids
    {
        public static string UdpInDatagrams => "1.3.6.1.2.1.7.1.0"; // Gelen UDP datagram sayısı
        public static string UdpNoPorts => "1.3.6.1.2.1.7.2.0"; // Geçerli bir port bulunamadığında alınan datagram sayısı
        public static string UdpInErrors => "1.3.6.1.2.1.7.3.0"; // Hatalı gelen UDP datagram sayısı
        public static string UdpOutDatagrams => "1.3.6.1.2.1.7.4.0"; // Gönderilen UDP datagram sayısı
        public static string UdpTable => "1.3.6.1.2.1.7.5"; // UDP bağlantı tablosu (aktif UDP portları ve IP adresleri)
    }

}
