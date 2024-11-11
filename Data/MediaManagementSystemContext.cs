using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaManagementSystem.Data
{
    public class MediaManagementSystemContext : DbContext
    {
        public MediaManagementSystemContext(DbContextOptions<MediaManagementSystemContext> options)
            : base(options)
        {
        }

        public DbSet<Devices> Devices { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<DeviceStatus> DeviceStatuses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-29KSL4M\\SQLEXPRESS;Database=MediaManagement;User ID=sa;Password=quocthai74");
        }
    }
}