using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lesson_08_07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var a = 5;
            var b = 6;

            //Арифметические операторы
            Console.WriteLine($"Сложение: {a + b}\n, Вычитание: {a - b}\n, " +
                $"Умножение: {a * b}\n, Деление: {a / b}, \nДеление с остатком: {b % a}");

             //уточнить в документации

            Console.WriteLine($"\t{(a + b) / a * 100}");

            string name = "Ilia";
            string surname = "Kataev";
            string separator = " ";
            bool isFalse = true;

            Console.WriteLine(surname + name);

            //Логические операторы
            // ! true false &&  || & | ~

            //!  1 = !0
            if (!isFalse)
            {
                Console.WriteLine("выавывып");
            }
            else
            {
                Console.WriteLine("cba");
            }

            bool aTrue = true;
            bool bFalse = false;

            Console.WriteLine($"a && b = {aTrue && bFalse}");

            Console.WriteLine($"a || b = { aTrue || bFalse}");

            // ||
            if (a + b == 12 || a * b == 30)
            {
                Console.WriteLine("ураа");
            }
            else
                Console.WriteLine("выражения ложные");
            // &&
            if (a + b == 11 && a * b == 10 && a - b == -1)
            {
                Console.WriteLine("ураа");
            }
            else
                Console.WriteLine("выражения ложные");

            int x = 5;    //0101     0,2^2,0,2^0 = 0, 4, 0 ,1
            int y = 3;    //0011 = 3 

            // & | ^ ~ 

            Console.WriteLine($"x & y = {x & y}"); //0001
            Console.WriteLine($"x | y = {x | y}"); //0111
            Console.WriteLine($" x ^ y = {x^y}"); // 0110
            Console.WriteLine($"~x = {~x}"); //

            //Операторы отношения

            // == !=  < > <= >=

            Console.WriteLine(a != b);
            Console.WriteLine(a > b);
            Console.WriteLine(a >= b);

            //new - создание
            Human human = new Human("Ilia");

            //другие

            // as is sizeof typeof checked unchecked

            Console.WriteLine(human is String);
            Console.WriteLine(typeof(Human));

            // if условие

            if (a > b)
                Console.WriteLine((Human)human);
            else if (a < b)
                Console.WriteLine(":)");
            else
            {
                int c = a + b;
                Console.WriteLine(c);
            }

            // switch case

            int num = 999;
            int sum = 0;
            switch (num)
            {
                case 0:
                    sum = 5;
                    break;
                case 1:
                    sum = 6;
                    break;
                case 2:
                    sum = 7;
                    break;
                case 3:
                    sum = 8;
                    break;
                case 4:
                    sum = 100;
                    break;
                default:
                    sum = 999999;
                    Console.WriteLine(sum);
                    break;
                    
            }
            Console.WriteLine(sum);

            // условие ? выражение1(true) : выражение2(false)

            int tern = num != sum ? 1 : 0;
            Console.WriteLine(tern);

            

            int count = 0;
            string birch = "кабак";

            for (int i = 0, j = birch.Length - 1; i < j; i++, j--)
            {
                if (birch[i] == birch[j])
                {
                    count++;
                }
            }

            if (count == birch.Length / 2)
                Console.WriteLine("Слово является палиндромом");

            //while

            Random rand = new Random();

            //while (true)
            //{
            //Console.WriteLine(rand.Next());
            //}

            count = 0;
            num = 0;
            sum = 0;

            while(sum <= 100)
            {
                num = rand.Next(0, 20);
                sum += num;
                count++;
            }
            Console.WriteLine("Сумма {0} чисел от 0 до 20 равна {1}", count, sum);

            //do while
            sum = 0;
            Console.WriteLine("Введите число: ");
            num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            do
            {
                sum += num % 10;
                num /= 10;
            }
            while(num > 0);
            Console.WriteLine("Сумма всех цифр числа {0} равна {1}", temp, sum);

            int[] container = new int[10];
            for (int i = 0; i < 10; i++)
            {
                container[i] = rand.Next(100);
                Console.WriteLine(container[i]);
            }
            sum = 0;
            int min = container[0], max = container[0];

            foreach (var item in container)
            {
                if (item % 2 != 0){
                    continue;
                }
                else
                {
                    sum += item;
                    if (item > max)
                        max = item;
                    else if (item < min)
                        min = item;
                }
                    
            }
            Console.WriteLine($"summa = {sum}, minimum = {min}, maximum = {max}");


            Practice1();


            


        }

        public static void Practice1()
        {
            ///Практика
            //Даны целые положительные числа A иB(A<B) .
            //Вывести все целые числа от A до B включительно;
            //каждое число должно выводиться на новой строке;
            //при этом каждое число должно выводиться количество раз, равное его значению
            //(например, число 3 выводится 3 раза).
            //Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод
            //3 3 3
            //4 4 4 4
            //5 5 5 5 5
            //6 6 6 6 6 6
            //7 7 7 7 7 7 7

            Console.Write("Введите А: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите Б: ");
            int b = int.Parse(Console.ReadLine());

            if(a >= b || a <= 0 || b <= 0)
            {
                Console.WriteLine("Неверные данные");
                return;
            }

            for(int i = a; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " "); // j = 0, j = 1 = 2 2 
                }
                Console.WriteLine();
            }


        }
        

    }

    public class Human
    {
        public string Name { get; set; }
        public Human(string name)
        {
            Name = name;
        }
    }
}
