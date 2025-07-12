using System;

namespace Lesson_12._07._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Работа со структурой
            double length = 7.999, width = 40.25;
            ExampleStruct exampleStruct = new ExampleStruct(length, width);
            exampleStruct.Print();

            // Метод, работающий со структурой и значимыми типами
            DoSomething();

            // Работа с классом Student
            Student student = new Student();
            student.Print();

            // Доступ к статическому полю
            Student student1 = new Student();
            Student.studentId = 10;
            Console.WriteLine(Student.studentId);

            // Демонстрация вызова разных конструкторов класса Car
            Car defaultCar = new Car();
            defaultCar.Print();

            Car parameterCar = new Car("Kataev", 220);
            parameterCar.Print();

            // Использование перегруженных методов
            int q = 2, w = 3, e = 4;
            double g = 10, f = 15, i = 20;

            Console.WriteLine(Math.Sum(q, w));
            Console.WriteLine(Math.Sum(q, w, e));
            Console.WriteLine(Math.Sum(g, f, i));

            
            City city = new City();
            city.StartBuilding();
        }

        // Метод, демонстрирующий работу со структурой без параметров
        public static void DoSomething()
        {
            ExampleStruct e;
            e = new ExampleStruct();
            e.Print();
            e.Width += 4;
            e.Length += 2;
            e.Print();
        }

        // Метод: произведение чисел в диапазоне
        static long RangePractice(int start, int end)
        {
            long result = 1;

            // Обеспечиваем правильный порядок
            if (start > end)
            {
                int temp = start;
                start = end;
                end = temp;
            }

            if (start == end)
                end++;

            for (int i = start; i <= end; i++)
                result *= i;

            return result;
        }

        // Метод: сортировка массива по возрастанию или убыванию
        static void SortArray(int[] array, bool asc)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if ((asc && array[i] > array[j]) || (!asc && array[i] < array[j]))
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
