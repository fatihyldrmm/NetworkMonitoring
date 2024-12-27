using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NetworkMonitoring.Domain.Models
{
    public class SnmpData : BaseEntity
    {
        [Required]
        public Guid DeviceId { get; set; }

        [ForeignKey("DeviceId")]
        public Device Device { get; set; }

        [Required]
        public string OID { get; set; }

        [Required]
        public string Value { get; set; }

        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
