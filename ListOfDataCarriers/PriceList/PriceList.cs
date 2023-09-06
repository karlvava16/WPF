using StorageDevices;
using ILogs;
using ISerializers;

namespace PL
{
    public class PriceList
    {
        protected List<StorageDevice> list = new List<StorageDevice>();



        public void Add(StorageDevice storage)
        {
            list.Add(storage);
        }
        public void Remove(StorageDevice storage)
        {
            list.Remove(storage);
        }

        public void Edit(StorageDevice ExistedStorage, StorageDevice EditedStorage)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == ExistedStorage)
                {
                    list[i] = EditedStorage;
                    return;
                }
            }
        }
        public StorageDevice this[int index]
        {
            get { return list[index]; }
        }

        public List<StorageDevice> Find(string find)
        {
            List<StorageDevice> listFind = new();
            foreach (StorageDevice storage in list)
            {
                if (storage.GetType().ToString().IndexOf(find, StringComparison.OrdinalIgnoreCase) != -1)
                {
                    listFind.Add(storage);
                }
                else if (storage.Manufacturer.IndexOf(find, StringComparison.OrdinalIgnoreCase) != -1)
                {
                    listFind.Add(storage);
                }
                else if (storage.Model.IndexOf(find, StringComparison.OrdinalIgnoreCase) != -1)
                {
                    listFind.Add(storage);
                }
                else if (storage.Appellation.IndexOf(find, StringComparison.OrdinalIgnoreCase) != -1)
                {
                    listFind.Add(storage);
                }
            }
            return listFind;
        }

        public void Print(ILog log)
        {
            foreach (StorageDevice storage in list)
            {
                storage.Print(log);
            }
        }

        public void Save(ISerialize serializable)
        {
            serializable.Save(list);
        }

        public void Load(ISerialize serializable)
        {
            list = serializable.Load();
        }
    }
}