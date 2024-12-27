using NetworkMonitoring.Domain.Models;

namespace SnmpProje.Services.Interfaces
{
    public interface IDeviceService
    {
        Task<Device> GetAllDeviceAsync();
        Task<Device> GetDeviceByIdAsync(Guid id);
        Task<Device> GetDeviceByIPAddressAsync(string ipAddress);
        Task<Device> CreateDeviceAsync(Device device);
        Task<Device> UpdateDeviceAsync(Guid id, Device device);
        Task<bool> DeleteDeviceAsync(Guid id);
    }
}
