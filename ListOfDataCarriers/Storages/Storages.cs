using ILogs;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace StorageDevices
{
    [Serializable]
    [KnownType(typeof(Flash))]
    [KnownType(typeof(DVD))]
    [KnownType(typeof(HDD))]
    [XmlInclude(typeof(Flash))]
    [XmlInclude(typeof(DVD))]
    [XmlInclude(typeof(HDD))]
    [DataContract]
    public abstract class StorageDevice
    {
        [DataMember]
        protected string manufacturer = "";
        [DataMember]
        protected string model = "";
        [DataMember]
        protected string appellation = "";


        public string Manufacturer { get { return manufacturer; } set { if (value != null) manufacturer = value; else manufacturer = ""; } }
        public string Model { get { return model; } set { if (value != null) model = value; else model = ""; } }
        public string Appellation { get { return appellation; } set { if (value != null) appellation = value; else appellation = ""; } }
        [DataMember]
        public uint Capacity { get; set; }
        [DataMember]
        public uint Amount { get; set; }


        public virtual void Print(ILog log)
        {
            log.Print(
                $"Type : {ToString()}\n" +
                $"Manufacturer : {Manufacturer}\n" +
                $"Model: {Model}\n" +
                $"Appellation : {Appellation}\n" +
                $"Capacity : {Capacity}\n" +
                $"Amount : {Amount}\n\n"
                );
        }
    }

    [Serializable]
    [DataContract]
    public class Flash : StorageDevice
    {

        [DataMember]
        public uint USBSpeed { get; set; }
        public override void Print(ILog log)
        {
            log.Print(
                $"Type : {ToString()}\n" +
                $"Manufacturer : {Manufacturer}\n" +
                $"Model: {Model}\n" +
                $"Appellation : {Appellation}\n" +
                $"Capacity : {Capacity}\n" +
                $"USB Speed : {USBSpeed} Mbps\n" +
                $"Amount : {Amount}\n\n"
                );
        }
    }

    [Serializable]
    [DataContract]
    public class HDD : StorageDevice
    {
        [DataMember]
        public uint DiskSpeed {get; set;}
        public override void Print(ILog log)
        {
            log.Print(
                $"Type : {ToString()}\n" +
                $"Manufacturer : {Manufacturer}\n" +
                $"Model: {Model}\n" +
                $"Appellation : {Appellation}\n" +
                $"Capacity : {Capacity}\n" +
                $"Disk Speed : {DiskSpeed} RPM\n" +
                $"Amount : {Amount}\n\n"
                );
        }
    }

    [Serializable]
    [DataContract]
    public class DVD : StorageDevice
    {
        [DataMember]
        public uint RecordingSpeed { get; set; }
        public override void Print(ILog log)
        {
            log.Print(
                $"Type : {ToString()}\n" +
                $"Manufacturer : {Manufacturer}\n" +
                $"Model: {Model}\n" +
                $"Appellation : {Appellation}\n" +
                $"Capacity : {Capacity}\n" +
                $"Recording Speed : {RecordingSpeed} Mbps\n" +
                $"Amount : {Amount}\n\n"
                );
        }
    }
}