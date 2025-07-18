using System;

namespace Lesson_18._07._2025
{
    /// <summary>
    /// Класс Point демонстрирует:
    /// - Перегрузку операторов (операторы +, -, ==, !=).
    /// - Переопределение методов Object (ToString, Equals, GetHashCode).
    /// </summary>
    public class Point
    {
        public int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Перегрузка бинарного оператора "+".
        /// Объединяем координаты двух точек.
        /// </summary>
        public static Point operator +(Point a, Point b)
        {
            return new Point(a.x + b.x, a.y + b.y);
        }

        /// <summary>
        /// Перегрузка бинарного оператора "-".
        /// </summary>
        public static Point operator -(Point a, Point b)
        {
            return new Point(a.x - b.x, a.y - b.y);
        }

        /// <summary>
        /// Перегрузка оператора сравнения "==".
        /// Требует перегрузки "!=".
        /// </summary>
        public static bool operator ==(Point a, Point b)
        {
            return (a.x == b.x) && (a.y == b.y);
        }

        public static bool operator !=(Point a, Point b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Переопределение ToString для вывода объекта.
        /// </summary>
        public override string ToString()
        {
            return $"({x};{y})";
        }

        /// <summary>
        /// Рекомендуется переопределять Equals и GetHashCode при перегрузке == и !=.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is Point other)
            {
                return x == other.x && y == other.y;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return x ^ y;
        }
    }
}
