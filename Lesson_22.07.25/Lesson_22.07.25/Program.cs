using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_22._07._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LibraryTest();   // Делегат + явный BookFilter
            //EventTest();     // Событие + подписка
            //AnonTest();      // Анонимный метод в делегате
            //LambdaTest();    // Лямбда-фильтр
            //ExtensionTest(); // Extension-метод
            LINQTest();        // Набор LINQ-запросов
        }

        /// <summary>
        /// Демонстрация передачи поведения через ДЕЛЕГАТ.
        /// 1. Создаём библиотеку и наполняем её.
        /// 2. Объявляем переменную-делегат BookFilter и инициализируем анонимным методом.
        /// 3. Передаём делегат в FindBooks() — библиотека не знает условий поиска, она лишь вызывает делегат.
        /// </summary>
        public static void LibraryTest()
        {
            var library = new Library();
            library.AddBook(new Book("Театр", "Моэм", 1937));
            library.AddBook(new Book("Чума", "Камю", 1947));
            library.AddBook(new Book("Гордость и предубеждение", "Остен", 1813));

            // Объявляем делегат (анонимный метод). Можно было BookFilter filter = b => b.Year < 1940;
            BookFilter filter = delegate (Book book)
            {
                return book.Year < 1940;
            };

            var classic = library.FindBooks(filter);

            foreach (var item in classic)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Демонстрация СОБЫТИЙ.
        ///  - Подписка на событие BookAdd лямбдой.
        ///  - Добавление книги вызывает событие.
        ///  - Подписка вторым обработчиком (анонимный метод) — покажет мультикаст.
        /// </summary>
        public static void EventTest()
        {
            var library = new Library();

            // Подписка через ЛЯМБДА-ВЫРАЖЕНИЕ
            library.BookAdd += (Book b) => Console.WriteLine($"Добавлена новая книга {b}");

            // Добавление книги — триггер события
            library.AddBook(new Book("Пинбол 1973", "Мураками", 1980));

            // Подписка через АНОНИМНЫЙ МЕТОД (старый синтаксис, уже есть получше)
            library.BookAdd += delegate (Book b)
            {
                Console.WriteLine(b);
            };

            // Добавим ещё книгу, теперь должны сработать оба подписчика
            library.AddBook(new Book("Норвежский лес", "Мураками", 1987));
        }

        /// <summary>
        /// Демонстрация АНОНИМНОГО МЕТОДА при передаче делегата в FindBooks().
        /// Не обязательно заранее объявлять переменную BookFilter.
        /// </summary>
        public static void AnonTest()
        {
            var library = new Library();
            library.AddBook(new Book("Театр", "Моэм", 1937));
            library.AddBook(new Book("Чума", "Камю", 1947));
            library.AddBook(new Book("Гордость и предубеждение", "Остен", 1813));

            // Анонимный метод inline — фильтруем книги до 1940 года
            var classic = library.FindBooks(delegate (Book b)
            {
                return b.Year < 1940;
            });

            foreach (var item in classic)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Демонстрация ЛЯМБДА-ВЫРАЖЕНИЯ как замены анонимного метода.
        /// Код короче, читается лучше; современный C#, пользуемся.
        /// </summary>
        public static void LambdaTest()
        {
            var library = new Library();
            library.AddBook(new Book("Театр", "Моэм", 1937));
            library.AddBook(new Book("Чума", "Камю", 1947));
            library.AddBook(new Book("Гордость и предубеждение", "Остен", 1813));

            // Лямбда напрямую в параметре FindBooks
            var modern = library.FindBooks(b => b.Year > 1940);

            foreach (var item in modern)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Демонстрация EXTENSION-МЕТОДА.
        /// library.ByAuthor("Камю") читается так, будто этот метод родной член класса Library.
        /// Внутри он реализован через statc LibraryExtensions.ByAuthor().
        /// </summary>
        public static void ExtensionTest()
        {
            var library = new Library();
            library.AddBook(new Book("Театр", "Моэм", 1937));
            library.AddBook(new Book("Чума", "Камю", 1947));
            library.AddBook(new Book("Гордость и предубеждение", "Остен", 1813));

            // Вызов Extension-метода
            var kamuBooks = library.ByAuthor("Камю");

            foreach (var item in kamuBooks)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Демонстрация множества операций LINQ к коллекции книг.
        /// ВАЖНО: Library.FindBooks(b => true) используется как способ "получить все книги",
        /// т.к. у нас нет прямого метода AllBooks.
        /// </summary>
        public static void LINQTest()
        {
            var library = new Library();
            library.AddBook(new Book("Театр", "Моэм", 1937));
            library.AddBook(new Book("Чума", "Камю", 1947));
            library.AddBook(new Book("Гордость и предубеждение", "Остен", 1813));
            library.AddBook(new Book("Преступление и наказание", "Достоевский", 1866));
            library.AddBook(new Book("Мастер и Маргарита", "Булгаков", 1967));
            library.AddBook(new Book("Отцы и дети", "Тургенев", 1862));
            library.AddBook(new Book("Евгений Онегин", "Пушкин", 1833));
            library.AddBook(new Book("Война и мир", "Толстой", 1869));
            library.AddBook(new Book("Анна Каренина", "Толстой", 1877));
            library.AddBook(new Book("Идиот", "Достоевский", 1869));
            library.AddBook(new Book("Белая гвардия", "Булгаков", 1925));
            library.AddBook(new Book("Обломов", "Гончаров", 1859));
            library.AddBook(new Book("Три товарища", "Ремарк", 1936));
            library.AddBook(new Book("На Западном фронте без перемен", "Ремарк", 1929));
            library.AddBook(new Book("Собор Парижской Богоматери", "Гюго", 1831));
            library.AddBook(new Book("Отверженные", "Гюго", 1862));
            library.AddBook(new Book("Маленький принц", "Сент-Экзюпери", 1943));
            library.AddBook(new Book("451° по Фаренгейту", "Брэдбери", 1953));
            library.AddBook(new Book("Цветы для Элджернона", "Киз", 1966));
            library.AddBook(new Book("Шерлок Холмс: Собака Баскервилей", "Дойл", 1902));

            // ====== ПРИМЕР 1: сортировка по году (возрастание) + проекция в названия ======
            var sortedBooks = library
                .FindBooks(b => true)  // получить все
                .OrderBy(b => b.Year)  // LINQ-упорядочивание
                .Select(b => b.Title); // оставляем только названия

            // ====== ПРИМЕР 2: фильтрация по автору через лямбду + Select ======
            var newBooks = library
                .FindBooks(b => b.Author == "Дойл")
                .Select(b => b.Title);

            // ====== ПРИМЕР 3: сортировка по названию в обратном порядке ======
            var sortedDesc = library
                .FindBooks(b => true)
                .OrderByDescending(b => b.Title);

            // ====== ПРИМЕР 4: список уникальных авторов ======
            var authors = library
                .FindBooks(b => true)
                .Select(b => b.Author)
                .Distinct(); // Убираем повторы

            // ====== ПРИМЕР 5: группировка по автору ======
            var group = library
                .FindBooks(b => true)
                .GroupBy(b => b.Author);

            // Вывод результата группировки
            foreach (var item in group)
            {
                Console.WriteLine($"Автор {item.Key}");
                foreach (var book in item)
                {
                    Console.WriteLine("  " + book.Title);
                }
            }
        }
    }
}
