using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11._07._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayExample();
            //Array2D();
            //JaggedArray();
            //StringExample();
            //Zadanie1();
            //Zadanie1LINQ();

            //Zadanie2_0();
            Zadanie3();
        }

        public static void ArrayExample() //Одномерные массивы
        {
            var rand = new Random();
            int[] numbers = new int[5]; //Объявление массива
            int[] numbers_init = { 1, 2, 3, 4, 5 }; // сразу инициализированный массив

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(5, 20);
            }
            
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("\n" + numbers.Rank);

            Console.WriteLine("\n\n\n\n");

            Array numbers_copy = (Array)numbers.Clone();
            int[] numbers_object_copy = (int[])numbers.Clone();

            /////////////////
            string[] name;
            name = new string[4];

            char[] chars = { 'a', 'b', 'c' };

            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(chars[i]);
            }

            for (int i = 0; i < name.Length; i++)
            {
                name[i] = "example";
                Console.WriteLine(name[i]);
            }
            Console.WriteLine("....................");

            Console.WriteLine(name.Length);
            foreach (var n in name)
            {
                Console.WriteLine(n);
            }

            string[] strings = { "string", "ssss", "wwww", "oooo" };

            foreach (var s in strings)
            {
                Console.WriteLine(s);
            }

        }

        public static void Array2D() //многомерные массивы
        {
            int[,] martix = new int[3, 4];

            int[,] ints =
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            for(int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    Console.Write(ints[i, j] + " ");
                }
            }
        }

        public static void JaggedArray()
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[3];
            jagged[2] = new int[10];
            jagged[1] = new int[7];

            int[][] free =
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6, 7, 8, 9 },
                new int[] { 10, 0, 1, 12} 
            };

            for (int i = 0; i < free.Length; i++)
            {
                for (int j = 0; j < free[i].Length; j++)
                {
                    Console.Write(free[i][j] + " ");
                }
            }

            Console.Write(jagged.Rank);


        }

        public static void StringExample()
        {
            string str = "h,e,l,l,o";
            string strNew = "hello new world";
            string empty = string.Empty;
            string fromChars = new string(new char[] { 'a', 'b', 'c', ' '});
            Console.WriteLine(str + fromChars);
            Console.WriteLine(fromChars.Contains("c"));

            Console.WriteLine(string.Join(", ", new string[] {"one", "two"}));
            Console.WriteLine(string.Join(", ", new string[] { "one", "two" }).GetType());

            string[] strings = str.Split(',');
            foreach (string s in strings)
            {
                Console.WriteLine(s);
                Console.WriteLine(s.GetType());
            }
            char[] chars = strNew.ToCharArray();

            foreach (char c in chars.Where(c => c != ' '))
                Console.Write(c);

            char[] charsWithZero = new char[5];
            charsWithZero[0] = '1';
            charsWithZero[1] = '1';  

            foreach (char c in charsWithZero.Where(c => c != '\0'))
                Console.Write(c);







        }

        public static void EnumExample()
        {
            int number = (int)StatusCode.OK;
            string str = StatusCode.OK.ToString();
        }

        public static void Zadanie1()
        {
            int[] numbers = { 1,  2, 3, 4, 4, 5, 6, 7, 7, 8, 1, 1, };

            int evenCount = 0;
            int oddCount = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    evenCount++;
                else 
                    oddCount++;
            }

            int uniqueCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < i; j++)
                {
                    if(numbers[i] == numbers[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    uniqueCount++;
                }
            }
            Console.WriteLine(oddCount + " - нечетные числа");
            Console.WriteLine(evenCount + " - четные числа");
            Console.WriteLine(uniqueCount + " - уникальные числа");
        }

        public static void Zadanie1LINQ()
        {
            int[] numbers = { 1, 2, 3, 4, 4, 5, 6, 7, 7, 8, 1, 1, };

            int evenCount = numbers.Count(n => n % 2 == 0 );
            int oddCount = numbers.Count(n => n % 2 != 0);
            int uniqueCount = numbers.Distinct().Count();

            
            Console.WriteLine(oddCount + " - нечетные числа");
            Console.WriteLine(evenCount + " - четные числа");
            Console.WriteLine(uniqueCount + " - уникальные числа");
        }

        public static void Zadanie2_0() //=> Console.WriteLine(Count(new[] { 6, 3, 8, 1, 0, 10, 25, 47, 15, 2, 4 }, Convert.ToInt32(Console.ReadLine())));
        {
            int[] numbers = { 6, 3, 8, 1, 0, 10, 25, 47, 15, 2, 4 };
            Console.WriteLine(Count(numbers, Convert.ToInt32(Console.ReadLine())));
        }

        static int Count(int[] numbers, int value) => numbers.Count(n => n < value);

        public static void Zadanie3()
        {
            int[] numbers = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5, };

            string nums = string.Join(" ", numbers);

            Console.WriteLine("Введите три числа через пробел");
            string numsToFind = Console.ReadLine();

            int count = 0;
            int index = 0;


            while((index = nums.IndexOf(numsToFind, index)) != -1)
            {
                count++;
                index += 1;
            }

            Console.WriteLine(count);
        }
    }

    enum StatusCode
    {
        OK = 200, NotFound = 404, ServerError = 500
    }

    enum State
    {
        RUNNING, STOPPED, CLOSED, INPROGRESS
    }

    enum Role
    {
        Admin, User, Owner
    }

    enum Bytes : byte { A = 1, B =2 }
}
