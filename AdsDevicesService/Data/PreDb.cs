using System;
using System.Linq;
using AdsDevicesService.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace AdsDevicesService.Data
{
    public static class PreDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
        }

        private static void SeedData(AppDbContext context)
        {
            if(!context.Devices.Any())
            {
                System.Console.WriteLine("--> Seeding Data...");
                context.Devices.AddRange(
                    new Device() { AdsPort = 501, ByteSize = 4, Description = "Przepływ powietrza kanał A", Format = "F2", FullName = "PrzepA", HrModbus = 1, IndexGroup = 0x4020, IndexOffset = 166, InstancePath = "", TypeName = "REAL", Unit = "m/s" },
                    new Device() { AdsPort = 501, ByteSize = 4, Description = "Przepływ powietrza kanał B", Format = "F2", FullName = "PrzepA", HrModbus = 3, IndexGroup = 0x4020, IndexOffset = 170, InstancePath = "", TypeName = "REAL", Unit = "m/s" }   
                );

                context.SaveChanges();
            }
            else System.Console.WriteLine("--> Data is already here.");
        }
    }
}