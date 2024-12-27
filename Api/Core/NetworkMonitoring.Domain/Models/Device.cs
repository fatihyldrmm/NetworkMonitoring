using System.ComponentModel.DataAnnotations;

namespace NetworkMonitoring.Domain.Models
{
    public class Device : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string IPAddress { get; set; }

        [MaxLength(100)]
        public string Location { get; set; }

        public ICollection<SnmpData> SnmpData { get; set; }
        public ICollection<SyslogData> SyslogData { get; set; }
    }
}
