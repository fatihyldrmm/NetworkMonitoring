using NetworkMonitoring.Application.OidLists;
using NetworkMonitoring.Application.Repositories;
using NetworkMonitoring.Domain.Models;
using SnmpProje.Services.Interfaces;
using SnmpSharpNet;
using System.Net;

namespace NetworkMonitoring.Persistence.Services
{
    public class SnmpService : ISnmpService
    {
        private readonly ISnmpDataRepository _snmpDataRepository;
        private readonly ITcpRepository _tcpRepository;
        public SnmpService(ISnmpDataRepository snmpDataRepository, ITcpRepository tcpRepository)
        {
            _snmpDataRepository = snmpDataRepository;
            _tcpRepository = tcpRepository;
        }

        public async Task<Dictionary<string, string>> GetSnmpDataAsync(string ipAddress, string community, List<string> oids)
        {
            var snmpResults = new Dictionary<string, string>();

            try
            {
                // SNMP hedefi
                IpAddress target = new IpAddress(ipAddress);

                // SNMP parametreleri
                OctetString communityString = new OctetString(community);
                AgentParameters parameters = new AgentParameters(communityString)
                {
                    Version = SnmpVersion.Ver2 // SNMP Versiyonu
                };

                // SNMP hedef adresi ve portu
                UdpTarget udpTarget = new UdpTarget((IPAddress)target, 161, 2000, 1);

                // SNMP PDU oluştur
                Pdu pdu = new Pdu(PduType.Get);
                foreach (var oid in oids)
                {
                    pdu.VbList.Add(oid); // OID'leri ekle
                }

                // SNMP GET isteği gönder
                SnmpPacket response = udpTarget.Request(pdu, parameters);

                // Yanıtı işle
                if (response != null && response.Pdu.ErrorStatus == 0)
                {
                    foreach (Vb variableBinding in response.Pdu.VbList)
                    {
                        snmpResults[variableBinding.Oid.ToString()] = variableBinding.Value.ToString();
                    }
                }
                else
                {
                    throw new Exception($"SNMP Error: {response?.Pdu.ErrorStatus.ToString()}");
                }

                udpTarget.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching SNMP data: {ex.Message}");
                throw;
            }

            return await Task.FromResult(snmpResults);
        }

        public async Task<bool> SetSnmpDataAsync(string ipAddress, string community, string oid, string value)
        {
            try
            {
                // SNMP hedefi
                IpAddress target = new IpAddress(ipAddress);

                // SNMP parametreleri
                OctetString communityString = new OctetString(community);
                AgentParameters parameters = new AgentParameters(communityString)
                {
                    Version = SnmpVersion.Ver2 // SNMP Versiyonu
                };

                // SNMP hedef adresi ve portu
                UdpTarget udpTarget = new UdpTarget((IPAddress)target, 161, 2000, 1);

                // SNMP PDU oluştur
                Pdu pdu = new Pdu(PduType.Set);
                pdu.VbList.Add(new Oid(oid), new OctetString(value));

                // SNMP SET isteği gönder
                SnmpPacket response = udpTarget.Request(pdu, parameters);

                // Yanıtı işle
                if (response != null && response.Pdu.ErrorStatus == 0)
                {
                    udpTarget.Close();
                    return await Task.FromResult(true);
                }
                else
                {
                    throw new Exception($"SNMP Error: {response?.Pdu.ErrorStatus.ToString()}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error setting SNMP data: {ex.Message}");
                throw;
            }
        }

        public async Task<List<string>> GetTcpOidData(string host, string community)
        {
            SimpleSnmp snmp = new SimpleSnmp(host, community);
            if (!snmp.Valid)
            {
                throw new Exception("SNMP agent bilgileri hatalı.");
            }

            // Walk yaparak tüm OID'leri dolaş
            Dictionary<Oid, AsnType> result = snmp.Walk(SnmpVersion.Ver2, BaseOids.RootOid);
            if (result == null)
            {
                throw new Exception("SNMP walk işlemi başarısız.");
            }

            // OID'leri dön
            return result.Keys.Select(x => x.ToString()).ToList();

        }
        public async Task<List<string>> GetDeviceMibList(string host, string community)
        {
            // SNMP agent ile bağlantı kur
            SimpleSnmp snmp = new SimpleSnmp(host, community);
            if (!snmp.Valid)
            {
                throw new Exception("SNMP agent bilgileri hatalı.");
            }

            // Walk yaparak tüm OID'leri dolaş
            Dictionary<Oid, AsnType> result = snmp.Walk(SnmpVersion.Ver2, BaseOids.RootOid);
            if (result == null)
            {
                throw new Exception("SNMP walk işlemi başarısız.");
            }

            // OID'leri dön
            return result.Keys.Select(x => x.ToString()).ToList();
        }

        public Task<List<SnmpData>> GetAllSnmpDataAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SnmpData> GetSnmpDataByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<SnmpData> CreateSnmpDataAsync(SnmpData snmpData)
        {
            throw new NotImplementedException();
        }

    }
}