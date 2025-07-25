using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Пространство имён для проекта 25.07.2025
namespace Lesson_25._07._2025
{
    // Интерфейс, который должен реализовать каждый бронируемый объект
    public interface IBookable
    {
        string GetBookingInfo(); // Метод для вывода информации о брони
    }

    // Обобщённый класс бронирования, работает с любым типом, реализующим IBookable
    public class Booking<T> where T : IBookable
    {
        public Guid id { get; set; } = Guid.NewGuid(); // Уникальный идентификатор
        public T Item { get; set; } // Сам объект бронирования (например, отель или рейс)
        public DateTime Date { get; set; } // Дата брони
        public string ClientEmail { get; set; } // Email клиента

        public void Print()
        {
            Console.WriteLine($"Бронирование: {Item} для клиента {ClientEmail}");
        }

        // Вложенный класс, описывающий статус бронирования
        public class BookingStatus
        {
            public bool IsConfirmed { get; set; } // Подтверждено ли бронирование
            public string Comment { get; set; } // Комментарий к брони
        }

        public BookingStatus status { get; set; } = new BookingStatus(); // Статус брони
    }

    // Класс, представляющий комнату отеля
    public class HotelRoom : IBookable
    {
        public string HotelName { get; set; }
        public int RoomNumber { get; set; }

        public string GetBookingInfo()
        {
            return $"{HotelName}, room {RoomNumber}";
        }

        public override string ToString()
        {
            return $"{HotelName}, room {RoomNumber}";
        }
    }

    // Класс, представляющий авиарейс
    public class Flight : IBookable
    {
        public string FlightName { get; set; }
        public string Destination { get; set; }

        public string GetBookingInfo()
        {
            return $"до {Destination}, на {FlightName}";
        }

        public override string ToString()
        {
            return $"до {Destination}, на {FlightName}";
        }
    }

    // Статический вспомогательный класс, использующий обобщённые методы
    public static class BookingHelper
    {
        // Печатает краткую информацию о брони
        public static void PrintInfo<T>(Booking<T> booking) where T : IBookable
        {
            Console.WriteLine($"Бронирование объекта типа {typeof(T).Name}: c {booking.Date} по {booking.Date.AddDays(10)}");
        }
    }

    // Обобщённый интерфейс репозитория
    public interface IRepository<T>
    {
        void Add(T item);         // Добавить объект
        List<T> GetAll();         // Получить все объекты
    }

    // Репозиторий бронирований, типизированный на основе обобщений
    public class BookingRepository<T> : IRepository<Booking<T>> where T : IBookable
    {
        private List<Booking<T>> booking = new List<Booking<T>>();

        public void Add(Booking<T> item)
        {
            booking.Add(item);
        }

        public List<Booking<T>> GetAll()
        {
            return booking;
        }
    }
}

