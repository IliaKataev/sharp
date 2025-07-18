using System;
using System.Collections.Generic;

namespace Lesson_18._07._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Демонстрация перегрузки операторов:
            PointStuff();

            // Демонстрация абстрактного класса и полиморфизма:
            RobotStuff();

            // Демонстрация наследования и sealed:
            CatStuff();
        }

        public static void PointStuff()
        {
            Point a = new Point(10, 20);
            Point b = new Point(5, 15);
            Console.WriteLine(a + b); // Выводит (15;35)
            Console.WriteLine(a - b); // Выводит (5;5)
            Console.WriteLine(a == b); // false
        }

        public static void RobotStuff()
        {
            RobotVacuum robot = new RobotVacuum(1000);
            Console.WriteLine($"Заряд пылесоса: {robot.CalcBattery()}%");
            Console.WriteLine(robot.Talk());

            OptimusPrime robot1 = new OptimusPrime();
            Console.WriteLine($"Заряд Оптимуса: {robot1.CalcBattery()}%");
            Console.WriteLine(robot1.Talk());
        }

        public static void CatStuff()
        {
            Cat cat = new Cat("Leo", "Aby");
            cat.Eat(); // Переопределение виртуального метода
            cat.Meow();
            Console.WriteLine(cat);

            // Полиморфизм: переменная типа Animal указывает на объект Cat
            Animal ani2 = new Cat("name", "breed");
            Console.WriteLine(ani2.Name);

            // Список с базовым типом Animal
            List<Animal> animals = new List<Animal>
            {
                new Cat("Barsik", "Siam"),
                new PolarBear("Белый")
            };

            foreach (var animal in animals)
            {
                animal.Eat(); // Вызывается версия метода из реального типа объекта
            }
        }
    }
}
