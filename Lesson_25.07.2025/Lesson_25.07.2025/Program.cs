using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_25._07._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пример с обобщениями
            GenericExample();
        }

        // Пример работы с типизированной коллекцией List<string>
        public static void FirstExample()
        {
            List<string> list = new List<string>
            {
                "Италия",
                "Франция",
                "Россия",
            };

            foreach (var s in list)
            {
                Console.WriteLine("Страна: " + s);
            }

            // Объяснение:
            // List<T> — типизированная коллекция
            // ArrayList и Hashtable — устаревшие (не типизированные)
            // Stack, Queue, SortedList — специализированные коллекции
        }

        // Устаревшая коллекция, может хранить объекты разных типов
        public static void ArrayListExample()
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add("Text");
            list.Add(DateTime.Now);

            foreach (var item in list)
            {
                Console.Write(item + ", ");
            }
        }

        // Стек (LIFO — последний зашёл, первый вышел)
        public static void StackExample()
        {
            Stack stack = new Stack();
            stack.Push("Первый");
            stack.Push("Второй");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(stack.Pop());  // Удаляет и возвращает верхний
            Console.WriteLine(stack.Peek()); // Только смотрит верхний
        }

        // Очередь (FIFO — первый зашёл, первый вышел)
        public static void QueueExample()
        {
            Queue queue = new Queue();
            queue.Enqueue("Первый");
            queue.Enqueue("Второй");

            Console.WriteLine(queue.Dequeue()); // Удаляет и возвращает
            Console.WriteLine(queue.Peek());    // Только смотрит
        }

        // Устаревший Hashtable — не типизирован
        public static void HashtableExample()
        {
            Hashtable table = new Hashtable();
            table["one"] = 1;
            table["two"] = 2;

            Console.WriteLine(table["one"]);
        }

        // Сортированный список по ключу (ключи должны быть уникальны и сравнимы)
        public static void SortedListExample()
        {
            SortedList sortedList = new SortedList();
            sortedList["c"] = 3;
            sortedList["a"] = 1;
            sortedList["b"] = 2;

            foreach (DictionaryEntry entry in sortedList)
            {
                Console.WriteLine($"{entry.Key} = {entry.Value}");
            }
        }

        // Пример интерфейсов коллекций
        public static void InterfaceExamples()
        {
            // Интерфейсы коллекций:
            // ICollection — базовый
            // IList — коллекция с доступом по индексу
            // IDictionary — ключ-значение

            IDictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            ICollection<string> cities = new List<string> { "Moscow", "Tyumen", "Ekb" };
            List<string> cities2 = new List<string> { "Moscow", "Tyumen", "Ekb" };
        }

        // Пример использования дженериков с собственными типами
        public static void GenericExample()
        {
            var hotelBooking = new Booking<HotelRoom>
            {
                Item = new HotelRoom { HotelName = "Abracadabra", RoomNumber = 101 },
                ClientEmail = "vacation999@mail.ru",
                Date = DateTime.Now,
            };

            var flightBooking = new Booking<Flight>
            {
                Item = new Flight { FlightName = "Pobeda", Destination = "Siktivkar" },
                ClientEmail = "pumpkinpie2077@ya.ru",
                Date = DateTime.Now,
                status = new Booking<Flight>.BookingStatus { Comment = "cool", IsConfirmed = true },
            };

            hotelBooking.Print();
            flightBooking.Print();

            BookingHelper.PrintInfo(hotelBooking); // Обобщённый метод
        }
    }
}

        // Пример работы со списком клиенто

