namespace NetworkMonitoring.Application.OidLists
{
    public class IpOids
    {
        public static string IpForwarding => "1.3.6.1.2.1.4.1.0"; // IP yönlendirme durumu (aktif/pasif)
        public static string IpDefaultTTL => "1.3.6.1.2.1.4.2.0"; // Paketler için varsayılan yaşam süresi (TTL)
        public static string IpInReceives => "1.3.6.1.2.1.4.3.0"; // Gelen IP paket sayısı
        public static string IpInHdrErrors => "1.3.6.1.2.1.4.4.0"; // IP başlık hataları sayısı
        public static string IpInAddrErrors => "1.3.6.1.2.1.4.5.0"; // Yanlış adresle gelen paket sayısı
        public static string IpForwDatagrams => "1.3.6.1.2.1.4.6.0"; // Yönlendirilen datagram sayısı
        public static string IpInUnknownProtos => "1.3.6.1.2.1.4.7.0"; // Bilinmeyen protokoldeki gelen paketler
        public static string IpInDiscards => "1.3.6.1.2.1.4.8.0"; // İşlenmeyen ve atılan gelen paketler
        public static string IpInDelivers => "1.3.6.1.2.1.4.9.0"; // Üst katmanlara iletilen gelen IP paketleri
        public static string IpOutRequests => "1.3.6.1.2.1.4.10.0"; // Çıkan IP paket istekleri
        public static string IpOutDiscards => "1.3.6.1.2.1.4.11.0"; // İşlenmeyen ve atılan çıkan paketler
        public static string IpOutNoRoutes => "1.3.6.1.2.1.4.12.0"; // Yönlendirilemeyen çıkan paketler
        public static string IpReasmTimeout => "1.3.6.1.2.1.4.13.0"; // Yeniden montaj süre aşımı
        public static string IpReasmReqds => "1.3.6.1.2.1.4.14.0"; // Yeniden montaj için gereken paket sayısı
        public static string IpReasmOKs => "1.3.6.1.2.1.4.15.0"; // Başarıyla yeniden monte edilen paketler
        public static string IpReasmFails => "1.3.6.1.2.1.4.16.0"; // Yeniden montaj başarısızlıkları
        public static string IpFragOKs => "1.3.6.1.2.1.4.17.0"; // Başarıyla parçalanan paketler
        public static string IpFragFails => "1.3.6.1.2.1.4.18.0"; // Parçalama başarısızlıkları
        public static string IpFragCreates => "1.3.6.1.2.1.4.19.0"; // Oluşturulan parça sayısı
        public static string IpAddrTable => "1.3.6.1.2.1.4.20.0"; // IP adres tablosu
        public static string IpRouteTable => "1.3.6.1.2.1.4.21.0"; // IP yönlendirme tablosu
        public static string IpNetToMediaTable => "1.3.6.1.2.1.4.22.0"; // Ağ-medya çeviri tablosu
        public static string IpRoutingDiscards => "1.3.6.1.2.1.4.23.0"; // Atılan yönlendirme kayıtları
        public static string LastBitMask => "1.3.6.1.2.1.4.65536"; // Özel bir tanımlayıcı (Son bit maskesi)
    }



}
