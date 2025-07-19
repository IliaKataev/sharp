using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_19._07._25
{
    /// <summary>
    /// Интерфейс для устройств с функцией удаленного управления.
    /// Он наследуется от IDevice и IUpdatableFirmware.
    /// </summary>
    public interface IRemoteControl : IDevice, IUpdatableFirmware
    {
        void SendCommand(string command);
    }

    /// <summary>
    /// Интерфейс для консоли (упрощённый пример).
    /// </summary>
    public interface IConsole
    {
        void SendCommand(string command);
    }

    /// <summary>
    /// Умный хаб, реализует:
    /// - IRemoteControl (управление устройствами и обновление ПО)
    /// - IBatteryPowered (имеет батарею)
    /// - IConsole (получает команды из консоли).
    /// </summary>
    public class SmartHub : IRemoteControl, IBatteryPowered, IConsole
    {
        public string Model { get; }
        public string Manufacturer { get; }
        public int BatteryLevel { get; private set; } = 90;

        public SmartHub(string model, string manufacturer)
        {
            Model = model;
            Manufacturer = manufacturer;
        }

        public void Charge(int percent)
        {
            BatteryLevel = Math.Min(100, BatteryLevel + percent);
        }

        // Явная реализация интерфейсов — метод виден только при приведении к интерфейсу.
        void IRemoteControl.SendCommand(string command)
        {
            Console.WriteLine($"[Hub {Model}] Cmd: {command}");
        }

        void IConsole.SendCommand(string command)
        {
            Console.WriteLine($"Recieved command in console: {command}");
        }

        public void TurnOff()
        {
            Console.WriteLine($"[Hub {Model}] офлайн");
        }

        public void TurnOn()
        {
            Console.WriteLine($"[Hub {Model}] онлайн");
        }

        public void UpdateFirmware(string version)
        {
            Console.WriteLine($"[Hub {Model}] FW -> {version}");
        }
    }
}
