using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetworkMonitoring.Api.Application.Features.Query.Oid.Chart;
using NetworkMonitoring.Api.Application.OidLists;
using NetworkMonitoring.Api.Persistence.Fetcher;
using NetworkMonitoring.Api.Persistence.MongoDB;
using NetworkMonitoring.Domain.Models;
using SnmpProje.Services.Interfaces;

namespace NetworkMonitoring.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SnmpController : ControllerBase
    {
        private readonly ISnmpService _snmpService;
        private readonly SnmpRepository _repository;
        public SnmpController(ISnmpService snmpService, SnmpRepository repository)
        {
            _snmpService = snmpService;
            _repository = repository;
        }

        [HttpGet("device/{ipAddress}")]
        public async Task<IActionResult> GetSnmpData(string ipAddress, [FromQuery] List<string> oids)
        {
            try
            {
                string community = "public"; // Sabit topluluk ismi
                var results = await _snmpService.GetSnmpDataAsync(ipAddress, community, oids);
                return Ok(results);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Error = ex.Message });
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SnmpData>>> GetSnmpData()
        {
            var snmpData = await _snmpService.GetAllSnmpDataAsync();
            return Ok(snmpData);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SnmpData>> GetSnmpDataById(Guid id)
        {
            var data = await _snmpService.GetSnmpDataByIdAsync(id);
            if (data == null) return NotFound();

            return Ok(data);
        }

        [HttpPost]
        public async Task<ActionResult<SnmpData>> CreateSnmpData(SnmpData snmpData)
        {
            var createdData = await _snmpService.CreateSnmpDataAsync(snmpData);
            return CreatedAtAction(nameof(GetSnmpDataById), new { id = createdData.Id }, createdData);
        }

        [HttpGet("get-mib-list/{ipAddress}")]
        public async Task<IActionResult> GetDeviceMibList(string ipAddress)
        {
            var community = "public";
            var list = await _snmpService.GetDeviceMibList(ipAddress, community);
            return Ok(list);
        }

        [HttpGet("get-tcp-oid/{ipAddress}")]
        public async Task<IActionResult> GetTcpOids(string ipAddress)
        {
            var list = SnmpDataFetcher.FetchSnmpData("Tcp", OidRepository.GetTcpOids(), OidRepository.GetTcpOidNames(), ipAddress);
            //var community = "public";
            //var list = await _snmpService.GetTcpOidData(ipAddress, community);
            return Ok(list);
        }
        [HttpGet("get-udp-oid/{ipAddress}")]
        public async Task<IActionResult> GetUdpOids(string ipAddress)
        {
            var list = SnmpDataFetcher.FetchSnmpData("Upd", OidRepository.GetUdpOids(), OidRepository.GetUdpOidNames(), ipAddress);
            //var community = "public";
            //var list = await _snmpService.GetTcpOidData(ipAddress, community);
            return Ok(list);
        }
        [HttpGet("get-system-oid/{ipAddress}")]
        public async Task<IActionResult> GetSystemOids(string ipAddress)
        {
            var list = SnmpDataFetcher.FetchSnmpData("System", OidRepository.GetSystemOids(), OidRepository.GetSystemOidNames(), ipAddress);
            //var community = "public";
            //var list = await _snmpService.GetTcpOidData(ipAddress, community);
            return Ok(list);
        }
        [HttpGet("get-snmp-stats-oid/{ipAddress}")]
        public async Task<IActionResult> GetSnmpStatsOids(string ipAddress)
        {
            var list = SnmpDataFetcher.FetchSnmpData("SnmpStats", OidRepository.GetSnmpStatsOids(), OidRepository.GetSnmpStatsOidNames(), ipAddress);
            //var community = "public";
            //var list = await _snmpService.GetTcpOidData(ipAddress, community);
            return Ok(list);
        }
        [HttpGet("get-ip-oid/{ipAddress}")]
        public async Task<IActionResult> GetIpOids(string ipAddress)
        {
            var list = SnmpDataFetcher.FetchSnmpData("Ip", OidRepository.GetIpOids(), OidRepository.GetIpOidNmes(), ipAddress);
            //var community = "public";
            //var list = await _snmpService.GetTcpOidData(ipAddress, community);
            return Ok(list);
        }
        [HttpGet("get-interface-oid/{ipAddress}")]
        public async Task<IActionResult> GetInterfaceOids(string ipAddress)
        {
            var list = SnmpDataFetcher.FetchSnmpData("Interface", OidRepository.GetInterfaceOids(), OidRepository.GetInterfaceOidNames(), ipAddress);
            //var community = "public";
            //var list = await _snmpService.GetTcpOidData(ipAddress, community);
            return Ok(list);
        }
        [HttpGet("get-icmp-oid/{ipAddress}")]
        public async Task<IActionResult> GetIcmpOids(string ipAddress)
        {
            var list = SnmpDataFetcher.FetchSnmpData("Icmp", OidRepository.GetIcmpOids(), OidRepository.GetIcmpOidNames(), ipAddress);
            //var community = "public";
            //var list = await _snmpService.GetTcpOidData(ipAddress, community);
            return Ok(list);
        }
        [HttpGet("get-egp-oid/{ipAddress}")]
        public async Task<IActionResult> GetEgpOids(string ipAddress)
        {
            var list = SnmpDataFetcher.FetchSnmpData("Egp", OidRepository.GetEgpOids(), OidRepository.GetEgpOidNames(), ipAddress);
            //var community = "public";
            //var list = await _snmpService.GetTcpOidData(ipAddress, community);
            return Ok(list);
        }
        [HttpGet("get-egpcomm-oid/{ipAddress}")]
        public async Task<IActionResult> GetEgpCommunicationOids(string ipAddress)
        {
            var list = SnmpDataFetcher.FetchSnmpData("EgpComm", OidRepository.GetEgpCommunicationOids(), OidRepository.GetEgpCommunicationOidNames(), ipAddress);
            //var community = "public";
            //var list = await _snmpService.GetTcpOidData(ipAddress, community);
            return Ok(list);
        }
        [HttpGet("get-egp-at-oid/{ipAddress}")]
        public async Task<IActionResult> GetEgpAtOids(string ipAddress)
        {
            var list = SnmpDataFetcher.FetchSnmpData("EgpAt", OidRepository.GetEgpAtOids(), OidRepository.GetEgpAtOidNames(), ipAddress);
            //var community = "public";
            //var list = await _snmpService.GetTcpOidData(ipAddress, community);
            return Ok(list);
        }

        [HttpGet("get-oid-types")]
        public async Task<IActionResult> GetOidTypes()
        {
            var list = OidRepository.GetOidTypes();
            return Ok(list);
        }
        [HttpGet("get-tcp-datas")]
        public async Task<IActionResult> GetTcpDatas()
        {
            var data = await _repository.GetAllDataAsync();
            return Ok(data);
        }
    }
}
