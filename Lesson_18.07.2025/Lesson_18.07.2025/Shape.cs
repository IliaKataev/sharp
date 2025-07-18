using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_18._07._2025
{
    /* Разработать абстрактный класс «Геометрическая Фигура» 
     * с методами «Площадь Фигуры» и «Периметр Фигуры».
     Разработать классы-наследники: Треугольник, Квадрат,
     Ромб, Прямоугольник, Параллелограмм, Трапеция, Круг,
     Эллипс.Реализовать конструкторы, которые однозначно
     определяют объекты данных классов.
     Реализовать класс «Составная Фигура», который List<Shape> AllShapes = 
     может состоять из любого количества «Геометрических
     Фигур». Для данного класса определить метод нахождения
     площади фигуры.*/

    /// <summary>
    /// Triangle - треугольник, Square = квадрат, Rhombus = ромб, Rectangle = прямоугольник
    /// Параллелограмм - Parallelogram, Trapezoid = трапеция, Circle = круг, Ellips = эллипс
    /// </summary>
    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }

    public class Square : Shape
    {
        public double Side { get; private set; }
        public Square(double side)
        {
            Side = side;
        }

        public override double GetArea()
        {
            return Side * Side;
        }

        public override double GetPerimeter()
        {
            return 4 * Side;
        }
    }

    public class Triangle : Shape
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double GetArea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public override double GetPerimeter()
        {
            return A + B + C;
        }
    }

    public class Rhombus : Shape
    {
        public double Side { get; private set; }
        public double Height { get; private set; }

        public Rhombus(double side, double height)
        {
            Side = side;
            Height = height;
        }

        public override double GetArea()
        {
            return Side * Height;
        }

        public override double GetPerimeter()
        {
            return 4 * Side;
        }
    }

    public class Rectangle : Shape
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }

        public override double GetArea()
        {
            return A * B;
        }

        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }
    }

    public class Parallelogram : Shape
    {
        
        public double Height { get; private set; }
        public double Base { get; private set; }
        public double Side { get; private set; }

        public Parallelogram(double height, double @base, double side)
        {
            Height = height;
            Base = @base;
            Side = side;
        }

        public override double GetArea()
        {
            return Base * Height;
        }

        public override double GetPerimeter()
        {
            return 2 * (Base + Side);
        }
    }

    public class Trapezoid : Shape
    {
        public double BaseA { get; private set; }
        public double BaseB { get; private set; }
        public double SideC { get; private set; }
        public double SideD { get; private set; }
        public double Height { get; private set; }

        public Trapezoid(double baseA, double baseB, double sideC, double sideD, double height)
        {
            BaseA = baseA;
            BaseB = baseB;
            SideC = sideC;
            SideD = sideD;
            Height = height;
        }

        public override double GetArea()
        {
            return ((BaseA + BaseB) / 2) * Height;
        }

        public override double GetPerimeter()
        {
            return BaseA + BaseB + SideC + SideD;
        }
    }

    public class Circle : Shape
    {

    }

    public class Ellipse : Shape
    {

    }


}
