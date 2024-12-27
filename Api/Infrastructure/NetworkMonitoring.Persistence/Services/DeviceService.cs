using NetworkMonitoring.Application.Repositories;
using NetworkMonitoring.Domain.Models;
using SnmpProje.Services.Interfaces;

namespace NetworkMonitoring.Persistence.Services
{
    public class DeviceService : IDeviceService
    {
        public readonly IDeviceRepository _deviceRepository;

        public DeviceService(IDeviceRepository deviceRepository)
        {
            _deviceRepository = deviceRepository;
        }

        public Task<Device> CreateDeviceAsync(Device device)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteDeviceAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Device> GetAllDeviceAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Device> GetDeviceByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Device> GetDeviceByIPAddressAsync(string ipAddress)
        {
            throw new NotImplementedException();
        }

        public Task<Device> UpdateDeviceAsync(Guid id, Device device)
        {
            throw new NotImplementedException();
        }
    }
}
