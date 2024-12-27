namespace NetworkMonitoring.Application.OidLists
{
    public class IcmpOids
    {
        public static string IcmpInMsgs => "1.3.6.1.2.1.5.1.0"; // Gelen ICMP mesaj sayısı
        public static string IcmpInErrors => "1.3.6.1.2.1.5.2.0"; // Gelen ICMP hata sayısı
        public static string IcmpInDestUnreachs => "1.3.6.1.2.1.5.3.0"; // Ulaşılamaz hedef için gelen ICMP mesajları
        public static string IcmpInTimeExcds => "1.3.6.1.2.1.5.4.0"; // Zaman aşımı için gelen ICMP mesajları
        public static string IcmpInParmProbs => "1.3.6.1.2.1.5.5.0"; // Parametre problemi için gelen ICMP mesajları
        public static string IcmpInSrcQuenchs => "1.3.6.1.2.1.5.6.0"; // Kaynak kısıtlaması için gelen ICMP mesajları
        public static string IcmpInRedirects => "1.3.6.1.2.1.5.7.0"; // Yönlendirme için gelen ICMP mesajları
        public static string IcmpInEchos => "1.3.6.1.2.1.5.8.0"; // Gelen ICMP echo istekleri
        public static string IcmpInEchoReps => "1.3.6.1.2.1.5.9.0"; // Gelen ICMP echo yanıtları
        public static string IcmpInTimestamps => "1.3.6.1.2.1.5.10.0"; // Zaman damgası için gelen ICMP istekleri
        public static string IcmpInTimestampReps => "1.3.6.1.2.1.5.11.0"; // Zaman damgası için gelen ICMP yanıtları
        public static string IcmpInAddrMasks => "1.3.6.1.2.1.5.12.0"; // Adres maskesi için gelen ICMP istekleri
        public static string IcmpInAddrMaskReps => "1.3.6.1.2.1.5.13.0"; // Adres maskesi için gelen ICMP yanıtları
        public static string IcmpOutMsgs => "1.3.6.1.2.1.5.14.0"; // Giden ICMP mesaj sayısı
        public static string IcmpOutErrors => "1.3.6.1.2.1.5.15.0"; // Giden ICMP hata sayısı
        public static string IcmpOutDestUnreachs => "1.3.6.1.2.1.5.16.0"; // Ulaşılamaz hedef için giden ICMP mesajları
        public static string IcmpOutTimeExcds => "1.3.6.1.2.1.5.17.0"; // Zaman aşımı için giden ICMP mesajları
        public static string IcmpOutParmProbs => "1.3.6.1.2.1.5.18.0"; // Parametre problemi için giden ICMP mesajları
        public static string IcmpOutSrcQuenchs => "1.3.6.1.2.1.5.19.0"; // Kaynak kısıtlaması için giden ICMP mesajları
        public static string IcmpOutRedirects => "1.3.6.1.2.1.5.20.0"; // Yönlendirme için giden ICMP mesajları
        public static string IcmpOutEchos => "1.3.6.1.2.1.5.21.0"; // Giden ICMP echo istekleri
        public static string IcmpOutEchoReps => "1.3.6.1.2.1.5.22.0"; // Giden ICMP echo yanıtları
        public static string IcmpOutTimestamps => "1.3.6.1.2.1.5.23.0"; // Zaman damgası için giden ICMP istekleri
        public static string IcmpOutTimestampReps => "1.3.6.1.2.1.5.24.0"; // Zaman damgası için giden ICMP yanıtları
        public static string IcmpOutAddrMasks => "1.3.6.1.2.1.5.25.0"; // Adres maskesi için giden ICMP istekleri
        public static string IcmpOutAddrMaskReps => "1.3.6.1.2.1.5.26.0"; // Adres maskesi için giden ICMP yanıtları
    }
}