using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_19._07._25
{
    /// <summary>
    /// Интерфейс для задания приоритета у устройства.
    /// </summary>
    public interface IPriority
    {
        int Priority { get; }
    }

    /// <summary>
    /// Сенсор — устройство, которое реализует:
    /// - IDevice (основное поведение)
    /// - IPriority (имеет приоритет)
    /// - IComparable<Sensor> (можно сравнивать сенсоры между собой для сортировки).
    /// </summary>
    public class Sensor : IDevice, IPriority, IComparable<Sensor>
    {
        public string Model { get; }
        public string Manufacturer { get; }
        public int Priority { get; }

        public Sensor(string model, string manufacturer, int priority)
        {
            Model = model;
            Manufacturer = manufacturer;
            Priority = priority;
        }

        /// <summary>
        /// Метод для сравнения сенсоров по приоритету.
        /// </summary>
        public int CompareTo(Sensor other)
        {
            return Priority.CompareTo(other.Priority);
        }

        public void TurnOff() => Console.WriteLine($"[Сенсор {Model}] выключен");
        public void TurnOn() => Console.WriteLine($"[Сенсор {Model}] включен");

        public override string ToString()
        {
            return $"{Model}: {Priority}";
        }
    }
}
