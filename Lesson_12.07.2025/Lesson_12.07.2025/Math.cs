using System;

namespace Lesson_12._07._2025
{
    /// <summary>
    /// Демонстрация перегрузки методов.
    /// Один метод Sum вызывается с разным количеством и типами параметров.
    /// </summary>
    public class Math
    {
        // Сложение двух целых
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        // Сложение трёх целых
        public static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        // Сложение трёх чисел с плавающей точкой
        public static double Sum(double a, double b, double c)
        {
            return a + b + c;
        }
    }
}
