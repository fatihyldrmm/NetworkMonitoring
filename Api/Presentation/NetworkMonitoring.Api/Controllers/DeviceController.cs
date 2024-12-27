using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetworkMonitoring.Domain.Models;
using SnmpProje.Services.Interfaces;

namespace NetworkMonitoring.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceService _deviceService;

        public DeviceController(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Device>>> GetDevices()
        {
            var devices = await _deviceService.GetAllDeviceAsync();
            return Ok(devices);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Device>> GetDevice(Guid id)
        {
            var device = await _deviceService.GetDeviceByIdAsync(id);
            if (device == null) return NotFound();

            return Ok(device);
        }

        [HttpGet("by-ip/{ipAddress}")]
        public async Task<ActionResult<Device>> GetDeviceByIPAddress(string ipAddress)
        {
            var device = await _deviceService.GetDeviceByIPAddressAsync(ipAddress);
            if (device == null) return NotFound();

            return Ok(device);
        }

        [HttpPost]
        public async Task<ActionResult<Device>> CreateDevice(Device device)
        {
            var createdDevice = await _deviceService.CreateDeviceAsync(device);
            return CreatedAtAction(nameof(GetDevice), new { id = createdDevice.Id }, createdDevice);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDevice(Guid id, Device device)
        {
            if (id != device.Id) return BadRequest();

            var updatedDevice = await _deviceService.UpdateDeviceAsync(id, device);
            if (updatedDevice == null) return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDevice(Guid id)
        {
            var deleted = await _deviceService.DeleteDeviceAsync(id);
            if (!deleted) return NotFound();

            return NoContent();

        }
    }
}
