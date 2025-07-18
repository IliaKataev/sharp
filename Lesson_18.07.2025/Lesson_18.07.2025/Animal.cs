using System;

namespace Lesson_18._07._2025
{
    /// <summary>
    /// Базовый класс Animal демонстрирует:
    /// - НАСЛЕДОВАНИЕ: другие классы (Cat, PolarBear) наследуются от Animal.
    /// - Полиморфизм: виртуальный метод Eat() может быть переопределён.
    /// </summary>
    public class Animal
    {
        // Свойство для имени животного
        public string Name { get; set; }

        // Конструктор базового класса
        public Animal(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Виртуальный метод демонстрирует полиморфизм:
        /// может быть переопределен в производных классах.
        /// </summary>
        public virtual void Eat() => Console.WriteLine("Ням-ням");
    }

    /// <summary>
    /// Sealed класс: запрещено наследоваться от PolarBear.
    /// Это полезно, если класс логически завершен и расширение нежелательно.
    /// </summary>
    public sealed class PolarBear : Animal
    {
        public PolarBear(string name) : base(name)
        {
        }

        /// <summary>
        /// Переопределение виртуального метода Eat():
        /// реализация специфична для белого медведя.
        /// </summary>
        public override void Eat() => Console.WriteLine(Name + " сейчас ест. Лучше не мешать");
    }

    /// <summary>
    /// Класс-наследник Cat:
    /// - Добавляет собственное свойство (Breed).
    /// - Переопределяет ToString() из базового класса Object.
    /// </summary>
    public class Cat : Animal
    {
        public string Breed { get; set; }

        public Cat(string name, string breed) : base(name)
        {
            Breed = breed;
        }

        public void Meow() => Console.WriteLine("Мяу");

        /// <summary>
        /// Переопределение ToString() из System.Object.
        /// Демонстрирует анализ базового класса Object.
        /// </summary>
        public override string ToString()
        {
            return Name + " породы " + Breed;
        }
    }
}
