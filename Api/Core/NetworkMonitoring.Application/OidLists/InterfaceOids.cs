namespace NetworkMonitoring.Application.OidLists
{
    public class InterfaceOids
    {
        public static string IfNumber => "1.3.6.1.2.1.2.1.0"; // Ağ arabirimi sayısı
        public static string IfTable => "1.3.6.1.2.1.2.2"; // Ağ arabirimleri tablosu
                                                           // IfTable altında ifEntry (1.3.6.1.2.1.2.2.1) detaylarını içerir
    }
}
