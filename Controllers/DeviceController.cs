using System.Collections.Generic;
using AdsDevicesService.Data;
using AdsDevicesService.DTos;
using AdsDevicesService.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AdsDevicesService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceRepository _repository;
        private readonly IMapper _mapper;

        public DeviceController(IDeviceRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DeviceReadDto>> GetDevices()
        {
            System.Console.WriteLine("--> Getting Devices...");
            
            var deviceItem = _repository.GetAllDevices();

            return Ok(_mapper.Map<IEnumerable<DeviceReadDto>>(deviceItem));
        }

        [HttpGet("{id}", Name = "GetDeviceById")]
        public ActionResult<DeviceReadDto> GetDeviceById(int id)
        {
            System.Console.WriteLine("--> Getting device by id...");

            var deviceItem = _repository.GetDeviceById(id);

            if(deviceItem != null)
                return Ok(_mapper.Map<DeviceReadDto>(deviceItem));
            else return NotFound();
        }

        [HttpPost]
        public ActionResult<DeviceReadDto> AddDevice(DeviceAddDto deviceAddDto)
        {
            var deviceModel = _mapper.Map<Device>(deviceAddDto);
            _repository.AddDevice(deviceModel);
            _repository.SaveChanges();

            var deviceReadDto = _mapper.Map<DeviceReadDto>(deviceModel);

            return CreatedAtRoute(nameof(GetDeviceById), new {Id = deviceReadDto.Id}, deviceReadDto);
        }
    }
}