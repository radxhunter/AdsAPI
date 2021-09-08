using System.Collections.Generic;
using AdsDevicesService.Models;

namespace AdsDevicesService.Data
{
    public interface IDeviceRepository
    {
        bool SaveChanges();
        IEnumerable<Device> GetAllDevices();
        Device GetDeviceById(int id);
        void AddDevice(Device device);
    }
}