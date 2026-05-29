using System;

namespace ConverterApp
{
    /// <summary>
    /// Класс для конвертации величин
    /// </summary>
    public static class ConverterLogic
    {
        /// <summary>
        /// Выполняет конвертацию
        /// </summary>
        /// <param name="type">0-м→км, 1-км→м, 2-C→F, 3-F→C</param>
        /// <param name="value">Значение для конвертации</param>
        /// <returns>Результат конвертации</returns>
        /// <exception cref="ArgumentException">Неверный тип</exception>
        public static double Convert(int type, double value)
        {
            switch (type)
            {
                case 0: return value / 1000;
                case 1: return value * 1000;
                case 2: return value * 1.8 + 32;
                case 3: return (value - 32) / 1.8;
                default: throw new ArgumentException("Неверный тип");
            }
        }
        /// <summary>
        /// Метры в километры
        /// </summary>
        public static double MetersToKilometers(double meters) => meters / 1000;

        /// <summary>
        /// Километры в метры
        /// </summary>
        public static double KilometersToMeters(double km) => km * 1000;

        /// <summary>
        /// Цельсий в Фаренгейт
        /// </summary>
        public static double CelsiusToFahrenheit(double c) => c * 1.8 + 32;

        /// <summary>
        /// Фаренгейт в Цельсий
        /// </summary>
        public static double FahrenheitToCelsius(double f) => (f - 32) / 1.8;
    }
}