using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetworkMonitoring.Domain.Models;
using SnmpProje.Services.Interfaces;

namespace NetworkMonitoring.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SyslogController : ControllerBase
    {
        private readonly ISyslogService _syslogService;

        public SyslogController(ISyslogService syslogService)
        {
            _syslogService = syslogService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SyslogData>>> GetSyslogData()
        {
            var syslogData = await _syslogService.GetAllSyslogDataAsync();
            return Ok(syslogData);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SyslogData>> GetSyslogDataById(Guid id)
        {
            var data = await _syslogService.GetSyslogDataByIdAsync(id);
            if (data == null) return NotFound();

            return Ok(data);
        }

        [HttpPost]
        public async Task<ActionResult<SyslogData>> CreateSyslogData(SyslogData syslogData)
        {
            var createdData = await _syslogService.CreateSyslogDataAsync(syslogData);
            return CreatedAtAction(nameof(GetSyslogDataById), new { id = createdData.Id }, createdData);
        }
    }
}