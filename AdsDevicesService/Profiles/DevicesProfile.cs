using AdsDevicesService.DTos;
using AdsDevicesService.Models;
using AutoMapper;

namespace AdsDevicesService.Profiles
{
    public class DevicesProfile : Profile
    {
        public DevicesProfile()
        {
            //Source->Target
            CreateMap<Device, DeviceReadDto>();
            CreateMap<DeviceAddDto, Device>();
        }
    }
}