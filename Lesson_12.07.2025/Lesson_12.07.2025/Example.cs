using System;

namespace Lesson_12._07._2025
{
    /// <summary>
    /// Структура — значимый тип (value type), копируется по значению.
    /// Используется для хранения простых наборов данных.
    /// </summary>
    struct ExampleStruct
    {
        public double Length; // Поле длины
        public double Width;  // Поле ширины

        // Пользовательский конструктор
        public ExampleStruct(double Length, double Width)
        {
            this.Length = Length;
            this.Width = Width;
        }

        // Метод вывода
        public void Print()
        {
            Console.WriteLine($"Длина: {Length}, Ширина: {Width}");
        }
    }
}
