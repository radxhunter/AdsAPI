using System;
using System.Collections.Generic;
using System.Linq;
using AdsDevicesService.Models;

namespace AdsDevicesService.Data
{
    public class DeviceRepository : IDeviceRepository
    {
        private readonly AppDbContext _context;

        public DeviceRepository(AppDbContext context)
        {
            _context = context;
        }
        public void AddDevice(Device device)
        {
            if(device == null)
                throw new ArgumentNullException(nameof(device));
            _context.Devices.Add(device);
        }

        public IEnumerable<Device> GetAllDevices()
        {
            return _context.Devices.ToList();
        }

        public Device GetDeviceById(int id)
        {
            return _context.Devices.FirstOrDefault(d => d.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}