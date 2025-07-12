using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12._07._2025
{
    public class City
    {
        /// <summary>
        /// Задание №3. 
        ///Создайте класс «Город». Необходимо хранить в полях класса: название города, название страны, 
        ///количество жителей в городе, телефонный код города, название районов города.
        ///Реализуйте методы класса для ввода данных, вывода данных. 
        ///Опционально: реализуйте доступ к отдельным полям через методы класса.
        /// </summary>
        public int Id { get; set; }
        public class Building
        {
            public void Build()
            {
                Console.WriteLine("Строим дом");
            }
        }

        public void StartBuilding()
        {
            Building build = new Building();
            build.Build();
        }
    }
}
