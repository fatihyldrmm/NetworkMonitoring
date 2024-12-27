namespace NetworkMonitoring.Application.OidLists
{
    public class SnmpStatsOids
    {
        public static string SnmpInPkts => "1.3.6.1.2.1.11.1.0"; // Gelen SNMP paketleri
        public static string SnmpOutPkts => "1.3.6.1.2.1.11.2.0"; // Giden SNMP paketleri
        public static string SnmpInBadVersions => "1.3.6.1.2.1.11.3.0"; // Versiyon numarası hatalı gelen SNMP paketleri
        public static string SnmpInBadCommunityNames => "1.3.6.1.2.1.11.4.0"; // Topluluk adı hatalı gelen SNMP paketleri
        public static string SnmpInBadCommunityUses => "1.3.6.1.2.1.11.5.0"; // Yanlış kullanım için gelen SNMP paketleri
        public static string SnmpInASNParseErrs => "1.3.6.1.2.1.11.6.0"; // ASN.1 parse hataları
        public static string SnmpInTooBigs => "1.3.6.1.2.1.11.8.0"; // "Too Big" hata mesajları
        public static string SnmpInNoSuchNames => "1.3.6.1.2.1.11.9.0"; // Var olmayan isimler için gelen SNMP paketleri
        public static string SnmpInBadValues => "1.3.6.1.2.1.11.10.0"; // Geçersiz değerler için gelen SNMP paketleri
        public static string SnmpInReadOnlys => "1.3.6.1.2.1.11.11.0"; // Salt okunur değişkenler için gelen SNMP istekleri
        public static string SnmpInGenErrs => "1.3.6.1.2.1.11.12.0"; // Genel hatalar
        public static string SnmpInTotalReqVars => "1.3.6.1.2.1.11.13.0"; // Toplam istek değişkenleri
        public static string SnmpInTotalSetVars => "1.3.6.1.2.1.11.14.0"; // Toplam ayar değişkenleri
        public static string SnmpInGetRequests => "1.3.6.1.2.1.11.15.0"; // Gelen Get istekleri
        public static string SnmpInGetNexts => "1.3.6.1.2.1.11.16.0"; // Gelen GetNext istekleri
        public static string SnmpInSetRequests => "1.3.6.1.2.1.11.17.0"; // Gelen Set istekleri
        public static string SnmpInGetResponses => "1.3.6.1.2.1.11.18.0"; // Gelen Get yanıtları
        public static string SnmpInTraps => "1.3.6.1.2.1.11.19.0"; // Gelen Trap mesajları
        public static string SnmpOutTooBigs => "1.3.6.1.2.1.11.20.0"; // Giden "Too Big" hata mesajları
        public static string SnmpOutNoSuchNames => "1.3.6.1.2.1.11.21.0"; // Var olmayan isimler için giden SNMP paketleri
        public static string SnmpOutBadValues => "1.3.6.1.2.1.11.22.0"; // Geçersiz değerler için giden SNMP paketleri
        public static string SnmpOutGenErrs => "1.3.6.1.2.1.11.24.0"; // Giden genel hata mesajları
        public static string SnmpOutGetRequests => "1.3.6.1.2.1.11.25.0"; // Giden Get istekleri
        public static string SnmpOutGetNexts => "1.3.6.1.2.1.11.26.0"; // Giden GetNext istekleri
        public static string SnmpOutSetRequests => "1.3.6.1.2.1.11.27.0"; // Giden Set istekleri
        public static string SnmpOutGetResponses => "1.3.6.1.2.1.11.28.0"; // Giden Get yanıtları
        public static string SnmpOutTraps => "1.3.6.1.2.1.11.29.0"; // Giden Trap mesajları
        public static string SnmpEnableAuthenTraps => "1.3.6.1.2.1.11.30.0"; // Yetkilendirme hataları için trap mesajları etkinleştirme
    }

}
