using PL;
using System.Text;
using StorageDevices;
using ILogs;
using ISerializers;

Console.OutputEncoding = Encoding.UTF8;

PriceList pl = new();

while (true)
{
    Console.Clear();
    Console.WriteLine
        (
        "1. Добавить носитель информации\n" +
        "2. Удалить носитель информации\n" +
        "3. Показать носители информации\n" +
        "4. Изменить носитель информации\n" +
        "5. Поиск носитель информации\n" +
        "6. Считать\\запись носитель информации\n"
        );

    ConsoleKeyInfo keyInfo = Console.ReadKey();
    switch (keyInfo.Key)
    {
        case ConsoleKey.D1:
            Add();
            break;
        case ConsoleKey.D2:
            Delete();
            break;
        case ConsoleKey.D3:
            Print();
            break;
        case ConsoleKey.D4:
            Edit();
            break;
        case ConsoleKey.D5:
            Find();
            break;
        case ConsoleKey.D6:
            SaveLoad();
            break;
    }
}

void Add()
{
    while (true)
    {
        
        Console.Clear();
        Console.WriteLine
            (
            "1. Добавить Flash\n" +
            "2. Добавить HDD\n" +
            "3. Добавить DVD\n" +
            "4. Отменить добавление\n"
            );

        ConsoleKeyInfo keyInfo = Console.ReadKey();

        switch (keyInfo.Key)
        {
            case ConsoleKey.D1:
                pl.Add(AddFlash());
                break;
            case ConsoleKey.D2:
                pl.Add(AddHDD());
                break;
            case ConsoleKey.D3:
                pl.Add(AddDVD());

                break;
            case ConsoleKey.D4:
                return;
        }
    }
}

HDD AddHDD()
{
    HDD hdd = new();

    Console.Clear();
    Console.WriteLine("|HDD|\n");

    Console.Write("Производитель : ");
    hdd.Manufacturer = Console.ReadLine();

    Console.Write("Модель : ");
    hdd.Model = Console.ReadLine();

    Console.Write("Наименование : ");
    hdd.Appellation = Console.ReadLine();

    Console.Write("Ёмкость носителя : ");
    hdd.Capacity = Convert.ToUInt32(Console.ReadLine());

    Console.Write("Cкорость Вращения Шпинделя (RPM) : ");
    hdd.DiskSpeed = Convert.ToUInt32(Console.ReadLine());

    Console.Write("Количество : ");
    hdd.Amount = Convert.ToUInt32(Console.ReadLine());

    return hdd;
}

Flash AddFlash()
{
    Flash flash = new();

    Console.Clear();
    Console.WriteLine("|Flash|\n");

    Console.Write("Производитель : ");
    flash.Manufacturer = Console.ReadLine();

    Console.Write("Модель : ");
    flash.Model = Console.ReadLine();

    Console.Write("Наименование : ");
    flash.Appellation = Console.ReadLine();

    Console.Write("Ёмкость носителя : ");
    flash.Capacity = Convert.ToUInt32(Console.ReadLine());

    Console.Write("Скорость USB (Mbps): ");
    flash.USBSpeed = Convert.ToUInt32(Console.ReadLine());

    Console.Write("Количество : ");
    flash.Amount = Convert.ToUInt32(Console.ReadLine());

    return flash;
}

DVD AddDVD()
{
    DVD dvd = new();

    Console.Clear();
    Console.WriteLine("|DVD|\n");

    Console.Write("Производитель : ");
    dvd.Manufacturer = Console.ReadLine();

    Console.Write("Модель : ");
    dvd.Model = Console.ReadLine();

    Console.Write("Наименование : ");
    dvd.Appellation = Console.ReadLine();

    Console.Write("Ёмкость носителя : ");
    dvd.Capacity = Convert.ToUInt32(Console.ReadLine());

    Console.Write("Скорость записи (Mbps): ");
    dvd.RecordingSpeed = Convert.ToUInt32(Console.ReadLine());

    Console.Write("Количество : ");
    dvd.Amount = Convert.ToUInt32(Console.ReadLine());

    return dvd;

}


void Print()
{

    while (true)
    {
        Console.Clear();
        Console.WriteLine
            (
            "1. Вывесть в консоль\n" +
            "2. Вывести в log файл\n" +
            "3. Отмена вывод\n"
            );

        ConsoleKeyInfo keyInfo = Console.ReadKey();
        Console.Clear();

        switch (keyInfo.Key)
        {
            case ConsoleKey.D1:
                pl.Print(new ConsoleLog());
                Console.ReadKey();
                break;
            case ConsoleKey.D2:
                try
                {
                    pl.Print(new FileLog());
                    Console.WriteLine("Log file saved");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
                Console.ReadKey();
                break;
            case ConsoleKey.D3:
                return;
        }
    }
}

List<StorageDevice>? Find()
{
    string search;
    List<StorageDevice> temp;

    while(true)
    {
        Console.Clear();
        Console.Write("Поиск : ");
        search = Console.ReadLine();
        Console.Clear();

        if (search == "")
            return null;

        temp = pl.Find(search);
        if (temp.Count != 0)
        {
            Console.WriteLine("| РЕЗУЛЬТАТЫ |\n");
            for (int i = 0; i < temp.Count; i++)
            {
                Console.WriteLine($"| РЕЗУЛЬТАТ # {i + 1} |");
                temp[i].Print(new ConsoleLog());
            }
            Console.ReadKey();
            return temp;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Нет результатов");
            Console.ReadKey();
            return null;
        }
    }
}

void Delete()
{
    int index;

    List<StorageDevice>? temp = Find();

    while (temp.Count != 0 && temp != null)
    {
        Console.Clear();
        Console.Write("Номер результата для удаления : ");
        try
        {
            index = Convert.ToInt32(Console.ReadLine()) - 1;
        }
        catch (Exception ex)
        {
            return;
        }
        if (index >= 0 && index <= temp?.Count - 1)
        {
            pl.Remove(temp[index]);
            Console.Clear();
            Console.WriteLine("| УДАЛЕНО |");
            temp[index].Print(new ConsoleLog());
            Console.ReadKey();
            return;
        }
        else
            return;
    }
}

void Edit()
{
    int index;

    List<StorageDevice>? temp = Find();

    while (temp != null && temp.Count != 0)
    {
        Console.Clear();
        Console.Write("Номер результата для изменения : ");
        try
        {
            index = Convert.ToInt32(Console.ReadLine()) - 1;
        }
        catch (Exception ex)
        {
            return;
        }
        if (index >= 0 && index <= temp?.Count - 1)
        {
            if (temp[index] is HDD)
            {
                pl.Edit(temp[index], AddHDD());
            }
            else if (temp[index] is DVD)
            {
                pl.Edit(temp[index], AddDVD());
            }
            else if(temp[index] is Flash)
            {
                pl.Edit(temp[index], AddFlash());
            }
            Console.WriteLine("| ИЗМЕНЕНО |");
            Console.ReadKey();
            return;
        }
        else
            return;
    }
}

void Save()
{
    while (true)
    {

        Console.Clear();
        Console.WriteLine
            (
            "1. Запись XML\n" +
            "2. Запись JSON\n" +
            "3. Отмена\n"
            );

        ConsoleKeyInfo keyInfo = Console.ReadKey();

        switch (keyInfo.Key)
        {
            case ConsoleKey.D1:
                pl.Save(new XMLSerialize());
                Console.Clear();
                Console.WriteLine("| Сохранено в XML |");
                Console.ReadKey();
                break;

            case ConsoleKey.D2:
                pl.Save(new JSONSerialize());
                Console.Clear();
                Console.WriteLine("| Сохранено в JSON |");
                Console.ReadKey();
                break;

            case ConsoleKey.D3:
                return;
        }
    }
}

void Load()
{
    while (true)
    {

        Console.Clear();
        Console.WriteLine
            (
            "1. Cчитать XML\n" +
            "2. Cчитать JSON\n" +
            "3. Отмена\n"
            );

        ConsoleKeyInfo keyInfo = Console.ReadKey();

        switch (keyInfo.Key)
        {
            case ConsoleKey.D1:
                try
                {
                    pl.Load(new XMLSerialize());
                    Console.Clear();
                    Console.WriteLine("| Cчитано с XML |");
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
                Console.ReadKey();
                break;

            case ConsoleKey.D2:
                try
                {
                    pl.Load(new JSONSerialize());
                    Console.Clear();
                    Console.WriteLine("| Cчитано с JSON |");
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
                Console.ReadKey();
                break;

            case ConsoleKey.D3:
                return;
        }
    }
 }

void SaveLoad()
{
    while (true)
    {

        Console.Clear();
        Console.WriteLine
            (
            "1. Cчитать\n" +
            "2. Запись\n" +
            "3. Отмена считать\\запись\n"
            );

        ConsoleKeyInfo keyInfo = Console.ReadKey();

        switch (keyInfo.Key)
        {
            case ConsoleKey.D1:
                Load();
                break;
            case ConsoleKey.D2:
                Save();
                break;
            case ConsoleKey.D3:
                return;
        }
    }
}