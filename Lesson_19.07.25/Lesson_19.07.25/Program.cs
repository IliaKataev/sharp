using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_19._07._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вызов тестовых методов для демонстрации работы кода.
            //DeviceTest();
            //DeviceCatalogTest();
            //IndexTest();
            //SmartHubTest();
            SensorTest();
        }

        /// <summary>
        /// Проверка работы умной лампы.
        /// </summary>
        public static void DeviceTest()
        {
            SmartLight light = new SmartLight("SmartBulb", "Yandex");
            light.TurnOn();
            light.TurnOff();
            light.UpdateFirmware("2.0");
            light.Charge(25);
            Console.WriteLine(light.BatteryLevel);
        }

        /// <summary>
        /// Проверка каталога устройств и включения всех устройств.
        /// </summary>
        public static void DeviceCatalogTest()
        {
            var catalog = new DeviceCatalog();
            catalog.Add(new SmartLight("V1", "Yandex"));
            catalog.Add(new SmartLight("Version Zero", "Yandex.Light"));
            catalog.TurnOnAll();
        }

        /// <summary>
        /// Проверка работы индексатора.
        /// </summary>
        public static void IndexTest()
        {
            var catalog = new DeviceCatalog();
            catalog.Add(new SmartLight("V1", "Yandex"));
            catalog.Add(new SmartLight("Version Zero", "Yandex.Light"));
            Console.WriteLine(catalog[0].Model); // Доступ к устройству через индексатор
            catalog[1].TurnOn();
        }

        /// <summary>
        /// Проверка умного хаба и его интерфейсов.
        /// Явное приведение к интерфейсам IRemoteControl и IConsole.
        /// </summary>
        public static void SmartHubTest()
        {
            var smartHub = new SmartHub("station 1", "Yandex");
            ((IRemoteControl)smartHub).SendCommand("welcome user");
            ((IConsole)smartHub).SendCommand("delete all");
        }

        /// <summary>
        /// Проверка сенсоров и сортировки по приоритету.
        /// </summary>
        public static void SensorTest()
        {
            var sensors = new List<Sensor>
            {
                new Sensor("proMax","Vision", 3),
                new Sensor("pro", "Vision", 2),
                new Sensor("regular", "VisVis", 1)
            };
            sensors.Sort(); // Сортировка по Priority

            foreach (var item in sensors)
            {
                Console.WriteLine(item);
            }
        }
    }
}
