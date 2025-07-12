using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Пользователь вводит с клавиатуры число в диапазоне от 1 до 100.Если число кратно 3(делится на 3 без
                остатка) нужно вывести слово Fizz. Если число кратно 5
                нужно вывести слово Buzz. Если число кратно 3 и 5 нужно
                вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно
                вывести само число.
                Если пользователь ввел значение не в диапазоне от 1
                до 100 требуется вывести сообщение об ошибке.*/

            Console.WriteLine("Ввести число от 1 до 100: ");
            string input = "23";

            if (int.TryParse(input, out int number))
            {
                if(number < 1 || number > 100 )
                    Console.WriteLine("число не в диапазоне");
                else
                {
                    if(number % 3 == 0 && number % 5 == 0)
                    {
                        Console.WriteLine("Fizz Buzz");
                    }
                    else if (number % 3 == 0)
                    {
                        Console.WriteLine("Fizz");  
                    }
                    else if(number % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(number + " число не поделилось");
                    }
                }
            }
            else
            {
                Console.WriteLine("Вы ввели не число");
            }

            /*Пользователь вводит с клавиатуры два числа. Первое
            число — это значение, второе число процент, который
            необходимо посчитать. Например, мыввели с клавиатуры
            90 и 10. Требуется вывести на экран 10 процентов от 90.
            Результат: 9.*/

            Console.Write("введите первое число: ");
            string input1 = Console.ReadLine();
            Console.Write("введите второе число: ");
            string input2 = Console.ReadLine();

            if (double.TryParse(input1, out double num1) && double.TryParse(input2, out double num2)) 
            { 
                double res = num1 * 100 / num2 ;
                Console.WriteLine($"Результар: {res}");
            }
            else
            {
                Console.WriteLine("Ошибка");
            }









                Console.ReadLine();
        }



        public void Add()
        {

            {
                //Console.Write("Введите ваше имя: ");
                //string name = Console.ReadLine();
                //Console.WriteLine("Добро пожаловать, " + name);

                //int a = int.Parse(Console.ReadLine());

                //int b = int.Parse(Console.ReadLine());

                int c = 255;


                int fsdfs = 0;

                int fl = -100;

                double doub = 0.6;

                decimal dec = 1;

                int? ab = null;

                string str = null;
                string str1 = "";

                Nullable<int> n = null;

                string abc = "abc";

                bool isNull = c < fl;

                int? nullInt = null;

                if (nullInt == null)
                    nullInt = 50;



                nullInt = nullInt ?? 50;






                Console.WriteLine(nullInt);

                //Console.WriteLine(a + b);

                Console.WriteLine((10U).GetType());

                Console.WriteLine(@"Пример буквального строгового литерала

\n1                                   \t2

 \t3\n4

                              \t5
\t6");


                int SullVar2;
                int sullVar2;

                int @int;

                @int = 5;

                int PascalCase;//Паскаль case Каждое новое слово с заглавной

                int camelCaseCase; //первое слово с прописной, остальные - с заглавной

                int UPPERCASE; //все с заглавной

                int _private = 1;

                Console.WriteLine(@int);
            }
            {
                int i = 0;
            }

            int counter = 0;

            for (int j = 0; j < 10; j++)
            {
                counter += 1;
            }

        }

    }

    
}
