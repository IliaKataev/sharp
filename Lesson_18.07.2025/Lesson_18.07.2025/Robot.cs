using System;

namespace Lesson_18._07._2025
{
    /// <summary>
    /// Абстрактный класс Robot:
    /// - Содержит общий функционал для всех роботов.
    /// - Имеет абстрактный метод Talk() для реализации в подклассах.
    /// </summary>
    public abstract class Robot
    {
        // Защищенное поле (protected): доступно только в классе и наследниках.
        protected int maxValue = 5000;

        // Автосвойство для хранения текущего заряда.
        public int Value { get; set; }

        /// <summary>
        /// Нереализованный (виртуальный) метод можно было бы сделать,
        /// но здесь CalcBattery реализован в базовом классе для всех роботов.
        /// </summary>
        public int CalcBattery()
        {
            return (int)((double)Value / maxValue * 100);
        }

        /// <summary>
        /// Абстрактный метод Talk():
        /// каждый робот обязан реализовать свою версию.
        /// </summary>
        public abstract string Talk();
    }

    /// <summary>
    /// Робот-пылесос.
    /// Переопределяет Talk().
    /// </summary>
    public class RobotVacuum : Robot
    {
        public RobotVacuum(int value)
        {
            // Если значение превышает максимум, ограничиваем его.
            Value = value > maxValue ? maxValue : value;
        }

        public override string Talk()
        {
            return "Я пылесошу";
        }
    }

    /// <summary>
    /// Робот Оптимус Прайм.
    /// </summary>
    public class OptimusPrime : Robot
    {
        public OptimusPrime()
        {
            // Если Value не задан, заполняем максимальным зарядом.
            if (Value == 0)
            {
                Value = maxValue;
            }
        }

        public override string Talk()
        {
            return "Я Оптимус Прайм";
        }
    }
}
