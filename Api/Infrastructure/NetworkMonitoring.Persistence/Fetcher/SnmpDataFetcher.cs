using NetworkMonitoring.Application.Features.Query.Oid.Chart;
using NetworkMonitoring.Application.OidLists;
using SnmpSharpNet;
using System.Net;

namespace NetworkMonitoring.Api.Persistence.Fetcher
{

    public static class SnmpDataFetcher
    {
        public static SnmpOidChartViewModel FetchSnmpData(string oidType,List<string> oids, List<string> oidNames, string host, string community = "public", int port = 161)
        {
            SnmpOidChartViewModel chartData = new SnmpOidChartViewModel();
            try
            {
                // SNMP Community and Agent Target
                OctetString communityStr = new OctetString(community);
                AgentParameters param = new AgentParameters(communityStr) { Version = SnmpVersion.Ver2 };
                byte[] byteArray = IPAddress.Parse(host).GetAddressBytes();
                IPAddress agent = new IPAddress(byteArray);
                UdpTarget target = new UdpTarget(agent, port, 2000, 1);
                chartData.OidType = oidType;
                // Fetch SNMP Data
                for (int i = 0; i < oids.Count; i++)
                {
                    try
                    {
                        Pdu pdu = new Pdu(PduType.Get);
                        pdu.VbList.Add(oids[i]);
                        SnmpV2Packet result = (SnmpV2Packet)target.Request(pdu, param);

                        if (result != null && result.Pdu.ErrorStatus == 0)
                        {
                            chartData.DataPoints.Add(new OID
                            {
                                OidName = oidNames[i], // Bu kategoriyi daha anlamlı bir değerle değiştirebilirsiniz
                                OidValue = result.Pdu.VbList[0].Value.ToString(),
                                TimeStamp = DateTime.Now
                            });
                        }
                        else
                        {
                            chartData.DataPoints.Add(new OID
                            {
                                OidName = oidNames[i],
                                OidValue = "0",
                                TimeStamp = DateTime.Now
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        chartData.DataPoints.Add(new OID
                        {
                            OidName = "Exception",
                            OidValue = "0",
                            TimeStamp = DateTime.Now
                        });
                    }
                }

                target.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return chartData;
        }
    }
}

