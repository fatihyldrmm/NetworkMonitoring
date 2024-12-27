using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NetworkMonitoring.Domain.Models
{
    public class SyslogData : BaseEntity
    {
        [Required]
        public Guid DeviceId { get; set; }

        [ForeignKey("DeviceId")]
        public Device Device { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
