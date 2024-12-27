namespace NetworkMonitoring.Application.OidLists
{
    public class EgpOids
    {
        public static string EgpInMsgs => "1.3.6.1.2.1.8.1.0"; // Gelen EGP mesaj sayısı
        public static string EgpInErrors => "1.3.6.1.2.1.8.2.0"; // Hatalı gelen EGP mesaj sayısı
        public static string EgpOutMsgs => "1.3.6.1.2.1.8.3.0"; // Gönderilen EGP mesaj sayısı
        public static string EgpOutErrors => "1.3.6.1.2.1.8.4.0"; // Hatalı giden EGP mesaj sayısı
        public static string EgpNeighTable => "1.3.6.1.2.1.8.5"; // EGP komşuluk tablosu
        public static string EgpAs => "1.3.6.1.2.1.8.6.0"; // EGP AS (Autonomous System) numarası
    }

}
