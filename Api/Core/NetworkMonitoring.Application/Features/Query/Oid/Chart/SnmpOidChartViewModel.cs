using NetworkMonitoring.Application.OidLists;

namespace NetworkMonitoring.Application.Features.Query.Oid.Chart
{
    public class SnmpOidChartViewModel
    {
        public string OidType { get; set; }
        public List<OID> DataPoints { get; set; } = new List<OID>();
    }
}
