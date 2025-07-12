using System;

namespace Lesson_12._07._2025
{
    /// <summary>
    /// Демонстрация модификаторов доступа:
    /// public, private, internal, protected, protected internal
    /// Также показаны: константы, readonly, статические поля
    /// </summary>
    class Student
    {
        public static int studentId = 3;                  // Статическое поле — общее для всех студентов
        const string firstName = "Ilia";                  // Константа — задаётся навсегда при компиляции
        readonly string lastName = "Kataev";              // Readonly — можно задать только в конструкторе или инициализации
        public readonly int age = 10;                     // Readonly поле — нельзя изменить после инициализации
        public readonly int[] grades = { 4, 5, 3, 5 };     // Readonly массив — массив можно изменить, но не ссылку
        string group = "bv411";                           // Приватное поле по умолчанию (internal/private)

        public void Print()
        {
            Console.WriteLine($"Студент {studentId} {firstName}, {lastName}");
        }
    }
}
