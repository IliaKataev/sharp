using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_19._07._25
{
    /// <summary>
    /// Основной интерфейс "Устройство".
    /// Определяет общие свойства и методы, которые должны быть у любого устройства.
    /// </summary>
    public interface IDevice
    {
        string Model { get; }           // Модель устройства
        string Manufacturer { get; }    // Производитель
        void TurnOff();                 // Метод для выключения
        void TurnOn();                  // Метод для включения
    }

    /// <summary>
    /// Интерфейс для устройств с обновляемым ПО.
    /// </summary>
    public interface IUpdatableFirmware
    {
        void UpdateFirmware(string version);
    }

    /// <summary>
    /// Интерфейс для устройств с батареей.
    /// </summary>
    public interface IBatteryPowered
    {
        int BatteryLevel { get; }       // Уровень заряда батареи
        void Charge(int percent);       // Зарядить устройство
    }

    /// <summary>
    /// Класс умной лампы, реализует несколько интерфейсов:
    /// - IDevice (общее устройство)
    /// - IUpdatableFirmware (может обновляться)
    /// - IBatteryPowered (имеет батарею)
    /// </summary>
    public class SmartLight : IDevice, IUpdatableFirmware, IBatteryPowered
    {
        public string Model { get; }
        public string Manufacturer { get; }

        // Закрытое свойство заряда батареи, по умолчанию 50%
        public int BatteryLevel { get; private set; } = 50;

        public SmartLight(string model, string manufacturer)
        {
            Model = model;
            Manufacturer = manufacturer;
        }

        public void TurnOff() => Console.WriteLine($"[Свет {Model}] выключен");

        public void TurnOn() => Console.WriteLine($"[Свет {Model}] включен");

        public void UpdateFirmware(string version)
        {
            // Обратите внимание: {1} и {0} используются для подстановки аргументов в формате строки
            Console.WriteLine("Произошло обновление {1} до версии {0}", version, Model);
        }

        public void Charge(int percent)
        {
            // Заряд не может быть выше 100%
            BatteryLevel = Math.Min(100, BatteryLevel + percent);
        }
    }
}

///Абстрактный класс и интерфейсы - ключевые различия:
///1. Абстрактный класс (например, Animal) - определяет сущность и может хранить состояние (поля).
///2. Интерфейс (например, IDevice) - только контракт "что делать", без полей и состояния.
///
