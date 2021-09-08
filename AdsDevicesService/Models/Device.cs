using System.ComponentModel.DataAnnotations;

namespace AdsDevicesService.Models
{
    public class Device
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string TypeName { get; set; }
        [Required]
        public string Unit { get; set; }
        [Required]
        public string Format { get; set; }
        [Required]
        public uint IndexGroup { get; set; }
        [Required]
        public uint IndexOffset { get; set; }
        [Required]
        public int ByteSize { get; set; }
        [Required]
        public int AdsPort { get; set; }
        public string InstancePath { get; set; }
        //public object AdsVariableValue { get; set; } //need to specify common type for: double, int, float, bool, byte.
        public ushort HrModbus { get; set; }
        public ushort Bit { get; set; }
    }
}