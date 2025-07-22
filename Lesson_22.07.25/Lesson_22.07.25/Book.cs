using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_22._07._25
{
    /// <summary>
    /// Класс-модель книги. 
    /// </summary>
    public class Book
    {
        // Автосвойства. Для примера оставляем set публичным,
        // чтобы проще менять данные при тестировании. В реале set обычно ограничивают.
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }


        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        /// <summary>
        /// Переопределяем ToString(), чтобы удобно выводить книгу в консоль.
        /// </summary>
        public override string ToString()
        {
            return $"\"{Title}\" {Author} ({Year})";
        }
    }

    /// <summary>
    /// Кастомный делегат-фильтр для книги.
    /// Возвращает true, если книга "подходит".
    /// 

    public delegate bool BookFilter(Book book);
}
