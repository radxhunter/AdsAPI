using AdsDevicesService.Models;
using Microsoft.EntityFrameworkCore;

namespace AdsDevicesService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }
        public DbSet<Device> Devices { get; set; }
    }
}