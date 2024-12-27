using Microsoft.EntityFrameworkCore;
using NetworkMonitoring.Domain.Models;
using System.Collections.Generic;

namespace NetworkMonitoring.Persistence.Context
{
    public class NetworkMonitoringContext : DbContext
    {
        public NetworkMonitoringContext(DbContextOptions<NetworkMonitoringContext> options) : base(options)
        {
        }

        public DbSet<Device> Devices { get; set; }
        public DbSet<SnmpData> SnmpDatas { get; set; }
        public DbSet<SyslogData> SyslogDatas { get; set; }
        public DbSet<TcpData> TcpDatas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Device>(entity =>
            {
                entity.HasIndex(d => d.IPAddress).IsUnique(); // Ensure unique IP addresses
            });

            modelBuilder.Entity<SnmpData>(entity =>
            {
                entity.HasIndex(s => s.OID); // Index for fast OID lookups
            });
        }
    }
}
