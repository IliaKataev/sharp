using System;

namespace Lesson_12._07._2025
{
    /// <summary>
    /// Конструкторы:
    /// - По умолчанию — без параметров
    /// - С параметрами — инициализация при создании
    /// - Статический — вызывается один раз при первом обращении к классу
    /// </summary>
    internal class Car
    {
        private string driverName;       // Приватное поле — доступно только внутри класса
        private static int speedBase;    // Статическое поле — общее для всех объектов Car
        private int speed;               // Обычное поле экземпляра — у каждого объекта своё

        // Конструктор без параметров
        public Car()
        {
            driverName = "Шумахер";
            Console.WriteLine("По умолчанию");
        }

        // Конструктор с параметрами
        public Car(string name, int speed)
        {
            driverName = name;
            this.speed = speed;
            Console.WriteLine("С параметрами");
        }

        // Статический конструктор — вызывается один раз при первом использовании класса
        static Car()
        {
            speedBase = 10;
            Console.WriteLine("Статический");
        }

        // Метод для вывода информации об объекте
        public void Print()
        {
            Console.WriteLine($"{driverName}, {speed}");
        }
    }
}
