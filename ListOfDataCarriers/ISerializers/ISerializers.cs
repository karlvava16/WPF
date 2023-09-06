using StorageDevices;
using System;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace ISerializers
{
    public interface ISerialize
    {
        public void Save(List<StorageDevice> list);
        public List<StorageDevice> Load();
    }

    public class XMLSerialize : ISerialize
    {
        public void Save(List<StorageDevice> list)
        {
            FileStream stream = new("../../../../data.xml", FileMode.Create);
            XmlSerializer serializer = new(typeof(List<StorageDevice>));

            serializer.Serialize(stream, list);
            stream.Close();
        }
        public List<StorageDevice> Load()
        {
            FileStream stream = new FileStream("../../../../data.xml", FileMode.Open);
            XmlSerializer serializer = new(typeof(List<StorageDevice>)); ;
            List<StorageDevice> temp = new();
            temp = (List<StorageDevice>)serializer.Deserialize(stream);
            stream.Close();
            return temp;
        }
    }

    public class JSONSerialize : ISerialize
    {
        public void Save(List<StorageDevice> list)
        {
            FileStream stream = new FileStream("../../../../data.json", FileMode.Create);
            DataContractJsonSerializer jsonFormatter = new(typeof(List<StorageDevice>));
            jsonFormatter.WriteObject(stream, list);
            stream.Close();
        }
        public List<StorageDevice> Load()
        {
            FileStream stream = new FileStream("../../../../data.json", FileMode.Open);
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<StorageDevice>));
            var list =  (List<StorageDevice>)jsonFormatter.ReadObject(stream);
            stream.Close();
            return list;
        }
    }
}