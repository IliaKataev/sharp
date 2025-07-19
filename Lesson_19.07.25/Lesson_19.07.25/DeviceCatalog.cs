using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_19._07._25
{
    /// <summary>
    /// Интерфейс только для чтения коллекции устройств.
    /// Это контракт, который определяет:
    ///  - Количество элементов (Count)
    ///  - Индексатор для доступа к элементам по индексу.
    /// </summary>
    public interface IReadableDeviceCollection
    {
        int Count { get; }        // Свойство только для чтения количества устройств
        IDevice this[int index] { get; } // Индексатор: получить устройство по номеру
    }

    /// <summary>
    /// Каталог устройств (коллекция), который реализует интерфейс IReadableDeviceCollection.
    /// Содержит внутренний список устройств и управляет ими.
    /// </summary>
    public class DeviceCatalog : IReadableDeviceCollection
    {
        // Внутреннее хранилище всех устройств (реализация на List).
        // Мы не даём доступ к самому List, чтобы защитить данные (инкапсуляция).
        private readonly List<IDevice> devices = new List<IDevice>();

        /// <summary>
        /// Количество устройств в каталоге.
        /// Реализация интерфейса IReadableDeviceCollection.
        /// </summary>
        public int Count => devices.Count;

        /// <summary>
        /// Добавление нового устройства в каталог.
        /// </summary>
        public void Add(IDevice device)
        {
            devices.Add(device);
        }

        /// <summary>
        /// Включить все устройства в каталоге.
        /// Применяется foreach для прохода по коллекции.
        /// </summary>
        public void TurnOnAll()
        {
            foreach (var device in devices)
            {
                device.TurnOn();
            }
        }

        /// <summary>
        /// Индексатор для доступа к устройству по его порядковому номеру.
        /// Если индекс некорректный, выбрасывается исключение.
        /// </summary>
        public IDevice this[int index]
        {
            get
            {
                if (index < 0 || index >= devices.Count)
                    throw new IndexOutOfRangeException("Неверный индекс девайса!");
                return devices[index];
            }
        }

        /// <summary>
        /// Свойство для безопасного доступа ко всем устройствам.
        /// Возвращает IEnumerable, чтобы нельзя было изменить коллекцию извне.
        /// </summary>
        public IEnumerable<IDevice> AllDevices => devices;
    }
}
