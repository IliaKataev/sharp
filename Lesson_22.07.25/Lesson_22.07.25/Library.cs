using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_22._07._25
{
    /// <summary>
    /// "Библиотека" — контейнер книг + демонстрация событий и делегатов.
    /// 
    /// Темы:
    /// - Событие BookAdd (публикация/подписка).
    /// - Метод AddBook вызывает событие (Publisher).
    /// - Метод FindBooks принимает делегат BookFilter (передача поведения).
    /// </summary>
    public class Library
    {
        /// <summary>
        /// Внутреннее хранилище книг. Инкапсулируем (скрываем) List, наружу не отдаём напрямую.
        /// </summary>
        private readonly List<Book> books = new List<Book>();

        /// <summary>
        /// СОБЫТИЕ: уведомление "в библиотеку добавлена книга".
        /// 
        /// Тип события — Action Book принимает книгу, ничего не возвращает.
        /// Почему event, а не просто поле делегата?
        ///  - Безопасность: внешние классы не смогут присвоить = null и обнулить подписчиков.
        ///  - Снаружи можно только подписаться (+=) или отписаться (-=).
        /// 
        /// Вызов (или же raise) в AddBook().
        /// </summary>
        public event Action<Book> BookAdd;

        /// <summary>
        /// Добавить книгу в библиотеку и оповестить подписчиков события BookAdd.
        /// </summary>
        public void AddBook(Book book)
        {
            books.Add(book);

            // Безопасный вызов события:
            // ?.Invoke — если подписчиков нет (BookAdd == null), вызов пропускается.
            // Иначе у всех подписчиков будет вызван их обработчик (мультикаст-делегат).
            BookAdd?.Invoke(book);
        }

        /// <summary>
        /// Удалить книгу (по ссылке).
        /// </summary>
        public void RemoveBook(Book book) => books.Remove(book);

        /// <summary>
        /// Поиск книг по делегату-фильтру.
        /// 
        /// 
        ///  Передача поведения через делегат BookFilter.
        ///  
        /// 
        /// Можно было бы уже тут заменить на более приятный LINQ (books.Where(filter)), но
        /// оставляем явный foreach для наглядности.
        /// </summary>
        public List<Book> FindBooks(BookFilter filter)
        {
            List<Book> result = new List<Book>();
            foreach (var book in books)
            {
                if (filter(book))
                {
                    result.Add(book);
                }
            }
            return result;
        }
    }

    /// <summary>
    /// Extension-методы для Library.
    /// 
    /// Extension = способ "добавить" методы к чужому (или закрытому) типу,
    /// не изменяя его исходный код.
    /// </summary>
    public static class LibraryExtensions
    {
        /// <summary>
        /// Возвращает книги по автору.
        /// 
        /// Ключевое слово "this" перед первым параметром говорит компилятору:
        ///   Library.ByAuthor("Автор") можно писать как "library.ByAuthor("Автор")".
        /// 
        /// Внутри используем Library.FindBooks(...) и лямбду b => b.Author == author,
        /// </summary>
        public static List<Book> ByAuthor(this Library library, string author)
        {
            return library.FindBooks(b => b.Author == author);
        }
    }
}
