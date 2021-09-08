namespace AdsDevicesService.DTos
{
    public class DeviceAddDto
    {
        public string FullName { get; set; }
        public string Description { get; set; }
        public string TypeName { get; set; }
        public string Unit { get; set; }
        public string Format { get; set; }
        public uint IndexGroup { get; set; }
        public uint IndexOffset { get; set; }
        public int ByteSize { get; set; }
        public int AdsPort { get; set; }
        public string InstancePath { get; set; }
        //public object AdsVariableValue { get; set; } //need to specify common type for: double, int, float, bool, byte.
        public ushort HrModbus { get; set; }
        public ushort Bit { get; set; }
    }
}